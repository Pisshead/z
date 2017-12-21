﻿using System;
using System.Windows.Forms;

namespace DatumUhrzeitRechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime(2017, 7, 18, 16, 35, 12);
            TimeSpan ts1 = new TimeSpan(2, 10, 5);
            TimeSpan ts2 = new TimeSpan(3, 4, 70, 10);

            LstAnzeige.Items.Add("Start: " + d);
            d = d.AddHours(3);
            LstAnzeige.Items.Add("+3 Std: " + d);
            d = d.AddHours(-2.5);
            LstAnzeige.Items.Add("-2,5 Std: " + d);
            d = d.AddHours(34);
            LstAnzeige.Items.Add("+34 Std: " + d);
            d = d.AddSeconds(90);
            LstAnzeige.Items.Add("+90 Sek: " + d);
            d = d.Add(ts1);
            LstAnzeige.Items.Add("+2 Std 10 Min 5 Sek: " + d);
            d = d.Subtract(ts2);
            LstAnzeige.Items.Add("-3 Tage 4 Std 70 Min 10 Sek: " + d);
        }
    }
}
