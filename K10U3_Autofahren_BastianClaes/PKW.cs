using System;
using System.Threading;
using System.Windows.Forms;

namespace K10U3
{
    public class PKW : Button
    {
        private int _geschwindigkeit = 50;

        public int Geschwindigkeit
        {
            get => _geschwindigkeit;
            set
            {
                // Sicherstellen, dass die Geschwindigkeit zwischen 0 und 100 ist.
                if(value <= 100 && value >= 0)
                    _geschwindigkeit = value;
            }
        }

        public void Fahren()
        {
            while (Parent.Width > Left + Width)
            {
                Thread.Sleep(100 - Geschwindigkeit);
                Left += 10;
                Application.DoEvents();
            }
        }
    }
}
