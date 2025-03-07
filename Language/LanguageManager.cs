﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SuchByte.MacroDeck.Language
{
    public static class LanguageManager
    {
        public static event EventHandler LanguageChanged;
        public static List<Strings> Languages { get { return _languages; } }
        private static List<Strings> _languages = new List<Strings>();

        private static Strings _strings = new Strings();
        public static Strings Strings { get { return _strings; } }


        public static void Load()
        {
            _languages.Clear();
            _languages.Add(_strings);
            if (Debugger.IsAttached)
            {
                SaveDefault();
            }

            // Load language files
            foreach (var file in Directory.GetFiles(MacroDeck.MainDirectoryPath + "Language", "*.xml"))
            {
                try
                {
                    using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                    
                        Strings strings = (Strings)new XmlSerializer(typeof(Strings)).Deserialize(stream);
                        if (_languages.FindAll(l => l.__Language__.Equals(strings.__Language__) && l.__LanguageCode__.Equals(strings.__LanguageCode__) && l.__Author__.Equals(strings.__Author__)).Count > 0) continue;
                        _languages.Add(strings);
                    }
                }
                catch { }
            }

            // Load user language files
            foreach (var file in Directory.GetFiles(MacroDeck.LanguagesPath, "*.xml"))
            {
                try
                {
                    using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                    
                        Strings strings = (Strings)new XmlSerializer(typeof(Strings)).Deserialize(stream);
                        if (_languages.FindAll(l => l.__Language__.Equals(strings.__Language__) && l.__LanguageCode__.Equals(strings.__LanguageCode__) && l.__Author__.Equals(strings.__Author__)).Count > 0) continue;
                        _languages.Add(strings);
                    }
                }
                catch { }
            }


            _languages = _languages.OrderBy(x => x.__Language__).ToList();
          
            foreach (Strings languageString in _languages)
            {
                Debug.WriteLine(languageString.__Language__);
            }
        }


        private static void SaveDefault()
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(Strings));

                var path = MacroDeck.MainDirectoryPath + "Language" + "//" + _strings.__Language__ + ".xml";
                using (FileStream fileStream = File.Create(path))
                {
                    writer.Serialize(fileStream, _strings);
                    fileStream.Close();
                }
                Debug.WriteLine("Default language file saved");
            } catch { }
        }

        public static void SetLanguage(string languageName)
        {
            Strings strings = _languages.Find(l => l.__Language__.Equals(languageName));
            if (strings != null)
            {
                Debug.WriteLine("Set language to " + languageName);
                _strings = strings;
                if (LanguageChanged != null)
                {
                    LanguageChanged(strings, EventArgs.Empty);
                }
            }
        }

        public static string GetLanguageName()
        {
            return _strings.__Language__;
        }

        public static string GetLanguageCode()
        {
            return _strings.__LanguageCode__;
        }

    }
}
