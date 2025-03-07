﻿
using SuchByte.MacroDeck.Variables;

namespace SuchByte.MacroDeck.GUI.MainWindowContents
{
    partial class VariablesView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            VariableManager.OnVariableChanged -= this.VariableChanged;
            VariableManager.OnVariableRemoved -= this.VariableRemoved;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.variablesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCreateVariable = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.SuspendLayout();
            // 
            // variablesPanel
            // 
            this.variablesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variablesPanel.AutoScroll = true;
            this.variablesPanel.Location = new System.Drawing.Point(0, 54);
            this.variablesPanel.Name = "variablesPanel";
            this.variablesPanel.Size = new System.Drawing.Size(1137, 450);
            this.variablesPanel.TabIndex = 11;
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.Location = new System.Drawing.Point(808, 1);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(212, 50);
            this.lblCreator.TabIndex = 15;
            this.lblCreator.Text = "Creator";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValue.Location = new System.Drawing.Point(544, 1);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(258, 50);
            this.lblValue.TabIndex = 14;
            this.lblValue.Text = "Value";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(363, 1);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(175, 50);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(3, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(354, 50);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreateVariable
            // 
            this.btnCreateVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCreateVariable.BorderRadius = 8;
            this.btnCreateVariable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateVariable.FlatAppearance.BorderSize = 0;
            this.btnCreateVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateVariable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateVariable.ForeColor = System.Drawing.Color.White;
            this.btnCreateVariable.Location = new System.Drawing.Point(1014, 510);
            this.btnCreateVariable.Name = "btnCreateVariable";
            this.btnCreateVariable.Size = new System.Drawing.Size(120, 27);
            this.btnCreateVariable.TabIndex = 16;
            this.btnCreateVariable.Text = "Create variable";
            this.btnCreateVariable.UseVisualStyleBackColor = false;
            this.btnCreateVariable.Click += new System.EventHandler(this.BtnCreateVariable_Click);
            // 
            // VariablesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.btnCreateVariable);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.variablesPanel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "VariablesView";
            this.Size = new System.Drawing.Size(1137, 540);
            this.Load += new System.EventHandler(this.VariablesPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel variablesPanel;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private CustomControls.ButtonPrimary btnCreateVariable;
    }
}
