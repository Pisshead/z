﻿namespace Konfigurationsdaten
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
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.Location = new System.Drawing.Point(12, 115);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(318, 134);
            this.LstAnzeige.TabIndex = 5;
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(12, 12);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 4;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.LstAnzeige);
            this.Controls.Add(this.CmdAnzeigen);
            this.Name = "Form1";
            this.Text = "Konfigurationsdaten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstAnzeige;
        private System.Windows.Forms.Button CmdAnzeigen;
    }
}

