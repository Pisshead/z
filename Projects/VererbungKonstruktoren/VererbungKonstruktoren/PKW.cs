﻿namespace VererbungKonstruktoren
{
    class PKW : Fahrzeug
    {
        private int insassen;

        public PKW()
        {
            insassen = 0;
        }

        public PKW(string b, int g, int i) : base(b, g)
        {
            insassen = i;
        }

        public void Einsteigen(int anzahl)
        {
            insassen += anzahl;
        }

        public override string ToString()
        {
            return "Insassen: " + insassen + "\n" + base.ToString();
        }
    }
}
