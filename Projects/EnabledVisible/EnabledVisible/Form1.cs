﻿using System;
using System.Windows.Forms;

namespace EnabledVisible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            if (TxtEingabe1.Text != "" && TxtEingabe2.Text != "")
            {
                CmdRechnen1.Enabled = true;
                CmdRechnen2.Visible = true;
            }
            else
            {
                CmdRechnen1.Enabled = false;
                CmdRechnen2.Visible = false;
            }
        }

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            try
            {
                LblAusgabe.Text = "Ergebnis: " +
                    (Convert.ToInt32(TxtEingabe1.Text) +
                    Convert.ToInt32(TxtEingabe2.Text));
            }
            catch
            {
                LblAusgabe.Text = "0";
            }
        }
    }
}
