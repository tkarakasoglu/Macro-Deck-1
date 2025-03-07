using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.Dialogs;
using SuchByte.MacroDeck.GUI.MainWindowContents;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Server;
using SuchByte.MacroDeck.Variables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuchByte.MacroDeck
{
    public static class MacroDeck
    {
        internal static readonly string VersionString = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        public static readonly int ApiVersion = 20;
        public static readonly int PluginApiVersion = 26;

        internal static bool ForceUpdate = false;
        internal static bool TestUpdateChannel = false;

        internal static bool SafeMode = false;

        internal static readonly string MainDirectoryPath = AppDomain.CurrentDomain.BaseDirectory + "\\";
        public static readonly string UserDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Macro Deck\\";
        public static readonly string PluginsDirectoryPath = UserDirectoryPath + "plugins\\";
        public static readonly string UpdatePluginsDirectoryPath = PluginsDirectoryPath + ".updates\\";
        public static readonly string TempDirectoryPath = UserDirectoryPath + ".temp\\";
        public static readonly string IconPackDirectoryPath = UserDirectoryPath + "iconpacks\\";
        public static readonly string PluginCredentialsPath = UserDirectoryPath + "credentials\\";
        public static readonly string PluginConfigPath = UserDirectoryPath + "configs\\";
        public static readonly string LanguagesPath = UserDirectoryPath + "languages\\";

        public static readonly string ConfigFilePath = UserDirectoryPath + "config.json";
        public static readonly string DevicesFilePath = UserDirectoryPath + "devices.json";
        public static readonly string VariablesFilePath = UserDirectoryPath + "variables.db";
        public static readonly string ProfilesFilePath = UserDirectoryPath + "profiles.db";

        public static event EventHandler OnMainWindowLoad;

        private static Events.EventManager _eventManager;
        private static Configuration.Configuration _configuration;
        private static Profiles.ProfileManager _profileManager;

        public static Events.EventManager EventManager { get { return _eventManager; } }
        public static Configuration.Configuration Configuration { get { return _configuration; } }
        public static Profiles.ProfileManager ProfileManager { get { return _profileManager; } }

        private static ContextMenuStrip _trayIconContextMenu = new ContextMenuStrip();

        private static NotifyIcon _trayIcon = new NotifyIcon
        {
            Icon = Properties.Resources.appicon,
            Text = "Macro Deck " + VersionString,
            Visible = true,
            ContextMenuStrip = _trayIconContextMenu
        };

        private static Task _mainWindowTask;


        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.ApplicationExit += OnApplicationExit;

            // Check if Macro Deck is already running
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                using (var messageBox = new GUI.CustomControls.MessageBox())
                {
                    messageBox.ShowDialog("Macro Deck is already running", "You can't start more than one instance of Macro Deck.", MessageBoxButtons.OK);
                }
                Environment.Exit(0);
                return;
            }

            // Register exception event handlers
            if (!Debugger.IsAttached)
            {
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += ApplicationThreadException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            }

            // Check if directories exist
            if (!Directory.Exists(UserDirectoryPath))
            {
                try
                {
                    Directory.CreateDirectory(UserDirectoryPath);
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }

            if (!Directory.Exists(PluginCredentialsPath))
            {
                try
                {
                    Directory.CreateDirectory(PluginCredentialsPath);
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }

            if (!Directory.Exists(PluginConfigPath))
            {
                try
                {
                    Directory.CreateDirectory(PluginConfigPath);
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }

            if (!Directory.Exists(TempDirectoryPath))
            {
                try
                {
                    Directory.CreateDirectory(TempDirectoryPath);
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            } else
            {
                // Clean up temp directory
                DirectoryInfo di = new DirectoryInfo(TempDirectoryPath);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }

            if (!Directory.Exists(LanguagesPath))
            {
                try
                {
                    Directory.CreateDirectory(LanguagesPath);
                    File.Create(MacroDeck.LanguagesPath + "Place_custom_translations_here");
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }

            // Check for start arguments
            int port = -1;
            bool show = false;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].ToLower().Equals("--port"))
                {
                    port = Int32.Parse(args[i + 1]);
                } else if (args[i].ToLower().Equals("--show"))
                {
                    show = true;
                }
                else if (args[i].ToLower().Equals("--force-update"))
                {
                    ForceUpdate = true;
                }
                else if (args[i].ToLower().Equals("--test-channel"))
                {
                    TestUpdateChannel = true;
                }
            }

            Language.LanguageManager.Load();

            // Check if config exists
            if (!File.Exists(ConfigFilePath))
            {
                // Start initial setup
                using (var initialSetup = new GUI.InitialSetup())
                {
                    Application.Run(initialSetup);
                    if (initialSetup.DialogResult == DialogResult.OK)
                    {
                        _configuration = initialSetup.configuration;
                        SaveConfiguration();
                        Start(true, port);
                    } else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                // Read config
                _configuration = JsonConvert.DeserializeObject<Configuration.Configuration>(File.ReadAllText(ConfigFilePath));
                Start(show, port);
            }
            
        }

        public static void SaveConfiguration()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            try
            {
                using StreamWriter sw = new StreamWriter(ConfigFilePath);
                using JsonWriter writer = new JsonTextWriter(sw);
                serializer.Serialize(writer, _configuration);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void Start(bool show = false, int port = -1)
        {
            Language.LanguageManager.SetLanguage(_configuration.Language);
            CreateTrayIcon();
            VariableManager.Load();
            _eventManager = new Events.EventManager();
            PluginManager.Load();
            PluginManager.OnUpdateCheckFinished += OnPackageManagerUpdateCheckFinished;
            PluginManager.EnablePlugins();
            Icons.IconManager.LoadIconPacks();
            Icons.IconManager.OnUpdateCheckFinished += OnPackageManagerUpdateCheckFinished;
            _profileManager = new Profiles.ProfileManager();

            MacroDeckServer.Start(_configuration.Host_Address, port == -1 ? _configuration.Host_Port : port);

            Updater.Updater.Initialize(ForceUpdate, TestUpdateChannel);
            Updater.Updater.OnUpdateAvailable += OnUpdateAvailable;


            // Register MacroDeckEvent event handlers and other listeners
            _profileManager.AddAllEventHandlers();
            _profileManager.AddVariableChangedListener();
            _profileManager.AddWindowFocusChangedListener();

            if (show || SafeMode)
            {
                ShowMainWindow();
            }

            Application.Run();
        }

        private static void OnUpdateAvailable(object sender, EventArgs e)
        {
            Debug.WriteLine("Update available");
            Updater.Updater.OnUpdateAvailable -= OnUpdateAvailable;
            JObject versionObject = sender as JObject;
            _trayIcon.ShowBalloonTip(5000, "Macro Deck Updater", String.Format(Language.LanguageManager.Strings.VersionXIsNowAvailable, versionObject["version"].ToString(), versionObject["channel"].ToString()), ToolTipIcon.Info);
        }

        private static void CreateTrayIcon()
        {
            ToolStripMenuItem showItem = new ToolStripMenuItem
            {
                Text = Language.LanguageManager.Strings.Show,
                Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
            };
            showItem.Click += ShowItemClick;

            ToolStripMenuItem restartItem = new ToolStripMenuItem
            {
                Text = Language.LanguageManager.Strings.Restart,
                Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
            };
            restartItem.Click += RestartItemClick;

            ToolStripMenuItem exitItem = new ToolStripMenuItem
            {
                Text = Language.LanguageManager.Strings.Exit,
                Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
            };
            exitItem.Click += ExitItemClick;

            _trayIconContextMenu.Items.Add(showItem);
            _trayIconContextMenu.Items.Add(restartItem);
            _trayIconContextMenu.Items.Add(exitItem);

            

            _trayIcon.MouseDown += OnTrayIconMouseDown;
        }

        private static void ShowItemClick(object sender, EventArgs e)
        {
            ShowMainWindow();
        }

        private static void RestartItemClick(object sender, EventArgs e)
        {
            Process.Start(MacroDeck.MainDirectoryPath + AppDomain.CurrentDomain.FriendlyName, (_mainWindowTask != null && !_mainWindowTask.IsCompleted ? "--show" : ""));
            Environment.Exit(0);
        }

        private static void ExitItemClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private static void OnTrayIconMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowMainWindow();
            }
        }

        public static void ShowMainWindow()
        {
            try
            {
                if (_mainWindowTask != null && !_mainWindowTask.IsCompleted) return;
                _mainWindowTask = new Task(delegate ()
                {
                    using (var mainWindow = new MainWindow())
                    {
                        mainWindow.Load += MainWindowLoadEvent;
                        mainWindow.ShowDialog();
                        mainWindow.Load -= MainWindowLoadEvent;
                    }
                });
                _mainWindowTask.RunSynchronously();
            } catch { }
        }

        private static void MainWindowLoadEvent(object sender, EventArgs e)
        {
            if (OnMainWindowLoad != null)
            {
                OnMainWindowLoad((MainWindow)sender, EventArgs.Empty);
            }
        }


        private static void OnApplicationExit(object sender, EventArgs e)
        {
            Debug.WriteLine("Application exit");
            VariableManager.Save();
            if (_trayIcon != null)
            {
                _trayIcon.Visible = false;
                _trayIcon.Icon.Dispose();
                _trayIcon.Dispose();
            }
            // Clean up temp dir
             foreach (var file in Directory.GetFiles(TempDirectoryPath))
             {
                try
                {
                    File.Delete(file);
                } catch { }
             }
             foreach (var dir in Directory.GetDirectories(TempDirectoryPath))
             {
                try
                {
                    Directory.Delete(dir, true);
                }
                catch { }
             }
        }

        private static void OnPackageManagerUpdateCheckFinished(object sender, EventArgs e)
        {
            PluginManager.OnUpdateCheckFinished -= OnPackageManagerUpdateCheckFinished;
            if (PluginManager.PluginsUpdateAvailable.Count > 0)
            {
                _trayIcon.ShowBalloonTip(5000, "Macro Deck Package Manager", Language.LanguageManager.Strings.UpdatesAvailable, ToolTipIcon.Info);
            }
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowCrashReport(e.ExceptionObject.ToString());
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowCrashReport(e.Exception.Message + Environment.NewLine + Environment.NewLine + e.Exception.StackTrace);
        }

        private static void ShowCrashReport(string crashReport)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.Equals("CrashReportDialog"))
                {
                    return;
                }
            }

            using (var crashReportDialog = new CrashReportDialog(crashReport))
            {
                crashReportDialog.ShowDialog();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
