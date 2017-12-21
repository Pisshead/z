﻿namespace Strukturen
{
    class Kontakt
    {
        public int plz;
        public string ort;
        public string strasse;
        public int hausnummer;
        public Telefon tel, fax;

        public Kontakt(){}

        public Kontakt(int p, string o, string s, int h,
            Telefon t, Telefon f)
        {
            plz = p;
            ort = o;
            strasse = s;
            hausnummer = h;
            tel = t;
            fax = f;
        }

        public override string ToString()
        {
            return strasse + " " + hausnummer + "\n" + plz + " " +
                ort + "\nTel: " + tel + "\nFax: " + fax;
        }
    }
}
