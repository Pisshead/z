﻿namespace MeinErstes
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdHallo = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 9);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(32, 15);
            this.LblAnzeige.TabIndex = 0;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdHallo
            // 
            this.CmdHallo.Location = new System.Drawing.Point(12, 36);
            this.CmdHallo.Name = "CmdHallo";
            this.CmdHallo.Size = new System.Drawing.Size(75, 23);
            this.CmdHallo.TabIndex = 1;
            this.CmdHallo.Text = "Hallo";
            this.CmdHallo.UseVisualStyleBackColor = true;
            this.CmdHallo.Click += new System.EventHandler(this.CmdHallo_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(12, 65);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 2;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdHallo);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "Mein Erstes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdHallo;
        private System.Windows.Forms.Button CmdEnde;
    }
}

