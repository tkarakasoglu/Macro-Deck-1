﻿using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Interfaces;
using System.Windows.Controls;
using ComboBox = SuchByte.MacroDeck.GUI.CustomControls.ComboBox;

namespace SuchByte.MacroDeck.GUI
{
    partial class ButtonEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (this.actionButton != null)
            {
                this.actionButton.StateChanged -= this.OnStateChanged;
            }
            if (this.actionButtonEdited != null)
            {
                this.actionButtonEdited.StateChanged -= this.OnStateChanged;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPath = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Label();
            this.btnApply = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.btnPreview = new SuchByte.MacroDeck.GUI.CustomControls.RoundedButton();
            this.labelText = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.lblButtonState = new System.Windows.Forms.Label();
            this.radioButtonOff = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.radioButtonOn = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAlignBottom = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.labelAlignCenter = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.labelAlignTop = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.btnEditIcon = new SuchByte.MacroDeck.GUI.CustomControls.PictureButton();
            this.btnRemoveIcon = new SuchByte.MacroDeck.GUI.CustomControls.PictureButton();
            this.btnClearLabelText = new SuchByte.MacroDeck.GUI.CustomControls.PictureButton();
            this.groupAppearance = new System.Windows.Forms.GroupBox();
            this.btnAddVariable = new SuchByte.MacroDeck.GUI.CustomControls.PictureButton();
            this.btnForeColor = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.fonts = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.lblCurrentStateLabel = new System.Windows.Forms.Label();
            this.btnOk = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.variablesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblStateBinding = new System.Windows.Forms.Label();
            this.listStateBinding = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.btnDeleteStateBinding = new SuchByte.MacroDeck.GUI.CustomControls.PictureButton();
            this.selectorPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioOnPress = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.radioOnEvent = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearLabelText)).BeginInit();
            this.groupAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddVariable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteStateBinding)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPath.Location = new System.Drawing.Point(460, 29);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(150, 19);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(616, 31);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(330, 16);
            this.buttonPath.TabIndex = 0;
            this.buttonPath.Text = ".";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnApply.BorderRadius = 8;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(184)))));
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(864, 708);
            this.btnApply.Name = "btnApply";
            this.btnApply.Progress = 0;
            this.btnApply.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnApply.Size = new System.Drawing.Size(75, 25);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreview.Column = 0;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.ForegroundImage = null;
            this.btnPreview.Location = new System.Drawing.Point(5, 51);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Radius = 40;
            this.btnPreview.Row = 0;
            this.btnPreview.ShowGIFIndicator = false;
            this.btnPreview.Size = new System.Drawing.Size(118, 118);
            this.btnPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPreview.TabIndex = 3;
            this.btnPreview.TabStop = false;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // labelText
            // 
            this.labelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.labelText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelText.Icon = null;
            this.labelText.Location = new System.Drawing.Point(155, 51);
            this.labelText.Multiline = true;
            this.labelText.Name = "labelText";
            this.labelText.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.labelText.PasswordChar = false;
            this.labelText.PlaceHolderColor = System.Drawing.Color.Gray;
            this.labelText.PlaceHolderText = "";
            this.labelText.ReadOnly = false;
            this.labelText.SelectionStart = 0;
            this.labelText.Size = new System.Drawing.Size(236, 85);
            this.labelText.TabIndex = 23;
            this.labelText.TabStop = false;
            this.labelText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelText.TextChanged += new System.EventHandler(this.LabelChanged);
            // 
            // fontSize
            // 
            this.fontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontSize.ForeColor = System.Drawing.Color.White;
            this.fontSize.Location = new System.Drawing.Point(337, 173);
            this.fontSize.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(54, 27);
            this.fontSize.TabIndex = 10;
            this.fontSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.LabelChanged);
            // 
            // lblButtonState
            // 
            this.lblButtonState.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblButtonState.Location = new System.Drawing.Point(3, 5);
            this.lblButtonState.Name = "lblButtonState";
            this.lblButtonState.Size = new System.Drawing.Size(130, 19);
            this.lblButtonState.TabIndex = 12;
            this.lblButtonState.Text = "Button state";
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.Checked = true;
            this.radioButtonOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonOff.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonOff.Location = new System.Drawing.Point(139, 3);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(70, 23);
            this.radioButtonOff.TabIndex = 13;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Off";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            this.radioButtonOff.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonOn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonOn.Location = new System.Drawing.Point(215, 3);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(70, 23);
            this.radioButtonOn.TabIndex = 14;
            this.radioButtonOn.Text = "On";
            this.radioButtonOn.UseVisualStyleBackColor = true;
            this.radioButtonOn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblButtonState);
            this.panel1.Controls.Add(this.radioButtonOn);
            this.panel1.Controls.Add(this.radioButtonOff);
            this.panel1.Location = new System.Drawing.Point(76, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 28);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelAlignBottom);
            this.panel2.Controls.Add(this.labelAlignCenter);
            this.panel2.Controls.Add(this.labelAlignTop);
            this.panel2.Location = new System.Drawing.Point(155, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 28);
            this.panel2.TabIndex = 16;
            // 
            // labelAlignBottom
            // 
            this.labelAlignBottom.AutoSize = true;
            this.labelAlignBottom.Checked = true;
            this.labelAlignBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlignBottom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAlignBottom.Location = new System.Drawing.Point(186, 3);
            this.labelAlignBottom.Name = "labelAlignBottom";
            this.labelAlignBottom.Size = new System.Drawing.Size(74, 22);
            this.labelAlignBottom.TabIndex = 11;
            this.labelAlignBottom.TabStop = true;
            this.labelAlignBottom.Text = "Bottom";
            this.labelAlignBottom.UseVisualStyleBackColor = true;
            this.labelAlignBottom.CheckedChanged += new System.EventHandler(this.LabelChanged);
            // 
            // labelAlignCenter
            // 
            this.labelAlignCenter.AutoSize = true;
            this.labelAlignCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlignCenter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAlignCenter.Location = new System.Drawing.Point(91, 3);
            this.labelAlignCenter.Name = "labelAlignCenter";
            this.labelAlignCenter.Size = new System.Drawing.Size(69, 22);
            this.labelAlignCenter.TabIndex = 10;
            this.labelAlignCenter.Text = "Center";
            this.labelAlignCenter.UseVisualStyleBackColor = true;
            this.labelAlignCenter.CheckedChanged += new System.EventHandler(this.LabelChanged);
            // 
            // labelAlignTop
            // 
            this.labelAlignTop.AutoSize = true;
            this.labelAlignTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlignTop.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAlignTop.Location = new System.Drawing.Point(3, 3);
            this.labelAlignTop.Name = "labelAlignTop";
            this.labelAlignTop.Size = new System.Drawing.Size(52, 22);
            this.labelAlignTop.TabIndex = 9;
            this.labelAlignTop.Text = "Top";
            this.labelAlignTop.UseVisualStyleBackColor = true;
            this.labelAlignTop.CheckedChanged += new System.EventHandler(this.LabelChanged);
            // 
            // btnEditIcon
            // 
            this.btnEditIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnEditIcon.BackgroundImage = global::SuchByte.MacroDeck.Properties.Resources.Edit_Normal;
            this.btnEditIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditIcon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditIcon.ForeColor = System.Drawing.Color.White;
            this.btnEditIcon.HoverImage = global::SuchByte.MacroDeck.Properties.Resources.Edit_Hover;
            this.btnEditIcon.Location = new System.Drawing.Point(37, 173);
            this.btnEditIcon.Name = "btnEditIcon";
            this.btnEditIcon.Size = new System.Drawing.Size(25, 25);
            this.btnEditIcon.TabIndex = 17;
            this.btnEditIcon.TabStop = false;
            this.btnEditIcon.Click += new System.EventHandler(this.BtnEditIcon_Click);
            // 
            // btnRemoveIcon
            // 
            this.btnRemoveIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveIcon.BackgroundImage = global::SuchByte.MacroDeck.Properties.Resources.Delete_Normal;
            this.btnRemoveIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveIcon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveIcon.ForeColor = System.Drawing.Color.White;
            this.btnRemoveIcon.HoverImage = global::SuchByte.MacroDeck.Properties.Resources.Delete_Hover;
            this.btnRemoveIcon.Location = new System.Drawing.Point(67, 173);
            this.btnRemoveIcon.Name = "btnRemoveIcon";
            this.btnRemoveIcon.Size = new System.Drawing.Size(25, 25);
            this.btnRemoveIcon.TabIndex = 18;
            this.btnRemoveIcon.TabStop = false;
            this.btnRemoveIcon.Click += new System.EventHandler(this.BtnRemoveIcon_Click);
            // 
            // btnClearLabelText
            // 
            this.btnClearLabelText.BackColor = System.Drawing.Color.Transparent;
            this.btnClearLabelText.BackgroundImage = global::SuchByte.MacroDeck.Properties.Resources.Delete_Normal;
            this.btnClearLabelText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearLabelText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLabelText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearLabelText.ForeColor = System.Drawing.Color.White;
            this.btnClearLabelText.HoverImage = global::SuchByte.MacroDeck.Properties.Resources.Delete_Hover;
            this.btnClearLabelText.Location = new System.Drawing.Point(397, 51);
            this.btnClearLabelText.Name = "btnClearLabelText";
            this.btnClearLabelText.Size = new System.Drawing.Size(27, 27);
            this.btnClearLabelText.TabIndex = 19;
            this.btnClearLabelText.TabStop = false;
            this.btnClearLabelText.Click += new System.EventHandler(this.BtnClearLabelText_Click);
            // 
            // groupAppearance
            // 
            this.groupAppearance.Controls.Add(this.btnAddVariable);
            this.groupAppearance.Controls.Add(this.btnForeColor);
            this.groupAppearance.Controls.Add(this.fonts);
            this.groupAppearance.Controls.Add(this.btnClearLabelText);
            this.groupAppearance.Controls.Add(this.panel2);
            this.groupAppearance.Controls.Add(this.labelText);
            this.groupAppearance.Controls.Add(this.panel1);
            this.groupAppearance.Controls.Add(this.btnEditIcon);
            this.groupAppearance.Controls.Add(this.btnRemoveIcon);
            this.groupAppearance.Controls.Add(this.fontSize);
            this.groupAppearance.Controls.Add(this.btnPreview);
            this.groupAppearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupAppearance.ForeColor = System.Drawing.Color.White;
            this.groupAppearance.Location = new System.Drawing.Point(12, 7);
            this.groupAppearance.Name = "groupAppearance";
            this.groupAppearance.Size = new System.Drawing.Size(442, 207);
            this.groupAppearance.TabIndex = 20;
            this.groupAppearance.TabStop = false;
            this.groupAppearance.Text = "Appearance";
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVariable.BackgroundImage = global::SuchByte.MacroDeck.Properties.Resources.Variable_Normal;
            this.btnAddVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddVariable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVariable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddVariable.ForeColor = System.Drawing.Color.White;
            this.btnAddVariable.HoverImage = global::SuchByte.MacroDeck.Properties.Resources.Variable_Hover;
            this.btnAddVariable.Location = new System.Drawing.Point(397, 84);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(27, 27);
            this.btnAddVariable.TabIndex = 22;
            this.btnAddVariable.TabStop = false;
            this.btnAddVariable.Click += new System.EventHandler(this.BtnAddVariable_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.BackColor = System.Drawing.Color.Transparent;
            this.btnForeColor.BackgroundImage = global::SuchByte.MacroDeck.Properties.Resources.icon_color_picker;
            this.btnForeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForeColor.BorderRadius = 8;
            this.btnForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForeColor.FlatAppearance.BorderSize = 0;
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForeColor.ForeColor = System.Drawing.Color.White;
            this.btnForeColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(184)))));
            this.btnForeColor.Icon = null;
            this.btnForeColor.Location = new System.Drawing.Point(405, 173);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Progress = 0;
            this.btnForeColor.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnForeColor.Size = new System.Drawing.Size(27, 27);
            this.btnForeColor.TabIndex = 21;
            this.btnForeColor.UseVisualStyleBackColor = false;
            this.btnForeColor.Click += new System.EventHandler(this.BtnForeColor_Click);
            // 
            // fonts
            // 
            this.fonts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.fonts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fonts.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fonts.ForeColor = System.Drawing.Color.White;
            this.fonts.Icon = null;
            this.fonts.Location = new System.Drawing.Point(155, 172);
            this.fonts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fonts.Name = "fonts";
            this.fonts.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.fonts.SelectedIndex = -1;
            this.fonts.SelectedItem = null;
            this.fonts.Size = new System.Drawing.Size(176, 28);
            this.fonts.TabIndex = 20;
            this.fonts.SelectedIndexChanged += new System.EventHandler(this.LabelChanged);
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.Location = new System.Drawing.Point(616, 63);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(29, 16);
            this.lblCurrentState.TabIndex = 22;
            this.lblCurrentState.Text = "Off";
            // 
            // lblCurrentStateLabel
            // 
            this.lblCurrentStateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentStateLabel.Location = new System.Drawing.Point(460, 60);
            this.lblCurrentStateLabel.Name = "lblCurrentStateLabel";
            this.lblCurrentStateLabel.Size = new System.Drawing.Size(150, 19);
            this.lblCurrentStateLabel.TabIndex = 23;
            this.lblCurrentStateLabel.Text = "Current state:";
            this.lblCurrentStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnOk.BorderRadius = 8;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(184)))));
            this.btnOk.Icon = null;
            this.btnOk.Location = new System.Drawing.Point(783, 708);
            this.btnOk.Name = "btnOk";
            this.btnOk.Progress = 0;
            this.btnOk.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // variablesContextMenu
            // 
            this.variablesContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.variablesContextMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.variablesContextMenu.Name = "variablesContextMenu";
            this.variablesContextMenu.ShowImageMargin = false;
            this.variablesContextMenu.ShowItemToolTips = false;
            this.variablesContextMenu.Size = new System.Drawing.Size(36, 4);
            // 
            // lblStateBinding
            // 
            this.lblStateBinding.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStateBinding.Location = new System.Drawing.Point(460, 91);
            this.lblStateBinding.Name = "lblStateBinding";
            this.lblStateBinding.Size = new System.Drawing.Size(150, 19);
            this.lblStateBinding.TabIndex = 26;
            this.lblStateBinding.Text = "State binding:";
            this.lblStateBinding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listStateBinding
            // 
            this.listStateBinding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.listStateBinding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listStateBinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listStateBinding.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listStateBinding.ForeColor = System.Drawing.Color.White;
            this.listStateBinding.Icon = null;
            this.listStateBinding.Location = new System.Drawing.Point(616, 91);
            this.listStateBinding.Name = "listStateBinding";
            this.listStateBinding.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.listStateBinding.SelectedIndex = -1;
            this.listStateBinding.SelectedItem = null;
            this.listStateBinding.Size = new System.Drawing.Size(290, 26);
            this.listStateBinding.TabIndex = 27;
            this.listStateBinding.SelectedIndexChanged += new System.EventHandler(this.ListStateBinding_SelectedIndexChanged);
            // 
            // btnDeleteStateBinding
            // 
            this.btnDeleteStateBinding.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteStateBinding.BackgroundImage = global::SuchByte.MacroDeck.Properties.Resources.Delete_Normal;
            this.btnDeleteStateBinding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteStateBinding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStateBinding.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteStateBinding.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStateBinding.HoverImage = global::SuchByte.MacroDeck.Properties.Resources.Delete_Hover;
            this.btnDeleteStateBinding.Location = new System.Drawing.Point(912, 91);
            this.btnDeleteStateBinding.Name = "btnDeleteStateBinding";
            this.btnDeleteStateBinding.Size = new System.Drawing.Size(27, 27);
            this.btnDeleteStateBinding.TabIndex = 28;
            this.btnDeleteStateBinding.TabStop = false;
            this.btnDeleteStateBinding.Click += new System.EventHandler(this.BtnDeleteStateBinding_Click);
            // 
            // selectorPanel
            // 
            this.selectorPanel.Location = new System.Drawing.Point(10, 257);
            this.selectorPanel.Name = "selectorPanel";
            this.selectorPanel.Size = new System.Drawing.Size(931, 445);
            this.selectorPanel.TabIndex = 29;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioOnPress);
            this.flowLayoutPanel1.Controls.Add(this.radioOnEvent);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 220);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(931, 31);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // radioOnPress
            // 
            this.radioOnPress.AutoSize = true;
            this.radioOnPress.Checked = true;
            this.radioOnPress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioOnPress.Location = new System.Drawing.Point(3, 3);
            this.radioOnPress.Name = "radioOnPress";
            this.radioOnPress.Size = new System.Drawing.Size(90, 23);
            this.radioOnPress.TabIndex = 0;
            this.radioOnPress.TabStop = true;
            this.radioOnPress.Text = "On press";
            this.radioOnPress.UseVisualStyleBackColor = true;
            this.radioOnPress.CheckedChanged += new System.EventHandler(this.RadioOnPress_CheckedChanged);
            // 
            // radioOnEvent
            // 
            this.radioOnEvent.AutoSize = true;
            this.radioOnEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioOnEvent.Location = new System.Drawing.Point(99, 3);
            this.radioOnEvent.Name = "radioOnEvent";
            this.radioOnEvent.Size = new System.Drawing.Size(91, 23);
            this.radioOnEvent.TabIndex = 1;
            this.radioOnEvent.Text = "On event";
            this.radioOnEvent.UseVisualStyleBackColor = true;
            this.radioOnEvent.CheckedChanged += new System.EventHandler(this.RadioOnEvent_CheckedChanged);
            // 
            // ButtonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(951, 744);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.selectorPanel);
            this.Controls.Add(this.btnDeleteStateBinding);
            this.Controls.Add(this.listStateBinding);
            this.Controls.Add(this.lblStateBinding);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCurrentState);
            this.Controls.Add(this.lblCurrentStateLabel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.groupAppearance);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ButtonEditor";
            this.Text = "Macro Deck :: Edit button";
            this.Load += new System.EventHandler(this.ButtonEditor_Load);
            this.Controls.SetChildIndex(this.groupAppearance, 0);
            this.Controls.SetChildIndex(this.lblPath, 0);
            this.Controls.SetChildIndex(this.buttonPath, 0);
            this.Controls.SetChildIndex(this.btnApply, 0);
            this.Controls.SetChildIndex(this.lblCurrentStateLabel, 0);
            this.Controls.SetChildIndex(this.lblCurrentState, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.lblStateBinding, 0);
            this.Controls.SetChildIndex(this.listStateBinding, 0);
            this.Controls.SetChildIndex(this.btnDeleteStateBinding, 0);
            this.Controls.SetChildIndex(this.selectorPanel, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearLabelText)).EndInit();
            this.groupAppearance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddVariable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteStateBinding)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label buttonPath;
        private CustomControls.ButtonPrimary btnApply;
        private CustomControls.RoundedButton btnPreview;
        private RoundedTextBox labelText;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label lblButtonState;
        private CustomControls.TabRadioButton radioButtonOff;
        private CustomControls.TabRadioButton radioButtonOn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.TabRadioButton labelAlignBottom;
        private CustomControls.TabRadioButton labelAlignCenter;
        private CustomControls.TabRadioButton labelAlignTop;
        private PictureButton btnEditIcon;
        private PictureButton btnRemoveIcon;
        private PictureButton btnClearLabelText;
        private System.Windows.Forms.GroupBox groupAppearance;
        private RoundedComboBox fonts;
        private ButtonPrimary btnForeColor;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.Label lblCurrentStateLabel;
        private ButtonPrimary btnOk;
        private PictureButton btnAddVariable;
        protected System.Windows.Forms.ContextMenuStrip variablesContextMenu;
        private System.Windows.Forms.Label lblStateBinding;
        private RoundedComboBox listStateBinding;
        private PictureButton btnDeleteStateBinding;
        private System.Windows.Forms.Panel selectorPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private TabRadioButton radioOnPress;
        private TabRadioButton radioOnEvent;
    }
}