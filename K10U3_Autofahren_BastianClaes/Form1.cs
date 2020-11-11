using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K10U3
{
    public partial class Form1 : Form
    {
        private PKW _pkw;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Falls diese existiert, entferne das vorherige PKW durch
            // Dispose
            if(_pkw != null)
                _pkw.Dispose();

            _pkw = new PKW();
            _pkw.Text = "PKW";
            _pkw.BackColor = Color.Red;
            _pkw.Top = strassePanel.Height - _pkw.Height;

            // Erwecke das PKW ins Leben! ... indem wir es zum Container des
            // Panels hinzufügen.
            strassePanel.Controls.Add(_pkw);

            fahrenButton.Enabled = true;
            GeschwindigkeitAktualisieren();
        }

        private void fahrenButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            fahrenButton.Enabled = false;
            langsamerButton.Enabled = true;
            schnellerButton.Enabled = true;

            GeschwindigkeitAktualisieren();
            _pkw.Left = 0;
            _pkw.Fahren();

            // Da PKW#Fahren() so lange läuft, bis das PKW am Rand des Panel ist
            // können wir direkt danach die Buttons enablen bzw. disablen.
            startButton.Enabled = true;
            fahrenButton.Enabled = true;
            langsamerButton.Enabled = false;
            schnellerButton.Enabled = false;
        }

        private void slowerButton_Click(object sender, EventArgs e)
        {
            _pkw.Geschwindigkeit -= 10;
            GeschwindigkeitAktualisieren();

        }

        private void fasterButton_Click(object sender, EventArgs e)
        {
            _pkw.Geschwindigkeit += 10;
            GeschwindigkeitAktualisieren();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GeschwindigkeitAktualisieren()
        {
            if(_pkw == null)
                Text = "Geschwindigkeit: ?";
            else
                Text = "Geschwindigkeit: " + _pkw.Geschwindigkeit;
        }
    }
}
