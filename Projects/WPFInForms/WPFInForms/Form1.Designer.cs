﻿namespace WPFInForms
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.WFO_Button = new System.Windows.Forms.Button();
            this.EHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.EHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // WFO_Button
            // 
            this.WFO_Button.Location = new System.Drawing.Point(12, 12);
            this.WFO_Button.Name = "WFO_Button";
            this.WFO_Button.Size = new System.Drawing.Size(160, 23);
            this.WFO_Button.TabIndex = 0;
            this.WFO_Button.Text = "Windows Forms Button";
            this.WFO_Button.UseVisualStyleBackColor = true;
            this.WFO_Button.Click += new System.EventHandler(this.WFO_Button_Click);
            // 
            // EHost1
            // 
            this.EHost1.Location = new System.Drawing.Point(12, 41);
            this.EHost1.Name = "EHost1";
            this.EHost1.Size = new System.Drawing.Size(160, 23);
            this.EHost1.TabIndex = 1;
            this.EHost1.Text = "elementHost1";
            this.EHost1.Child = null;
            // 
            // EHost2
            // 
            this.EHost2.Location = new System.Drawing.Point(12, 70);
            this.EHost2.Name = "EHost2";
            this.EHost2.Size = new System.Drawing.Size(160, 80);
            this.EHost2.TabIndex = 2;
            this.EHost2.Text = "elementHost2";
            this.EHost2.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.EHost2);
            this.Controls.Add(this.EHost1);
            this.Controls.Add(this.WFO_Button);
            this.Name = "Form1";
            this.Text = "WPFInForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WFO_Button;
        private System.Windows.Forms.Integration.ElementHost EHost1;
        private System.Windows.Forms.Integration.ElementHost EHost2;
    }
}

