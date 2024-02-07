using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS.Del3_Sanne
{
    public partial class fMain : Form
    {
        public static class GlobaleVaraibler
        {
            public static string rettBrukernavn = "SanneCodes"; // Standard brukernavn.
            public static string rettPassord = "Test"; // Standard passord.
            public static Boolean on = false; // Innloggingsstatus.
        }


        public fMain()
        {
            InitializeComponent(); // Initialiserer komponenter.
        }

        private void endrePassordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobaleVaraibler.on == true)
            {
                fEndrePassord NyttPassordVindu = new fEndrePassord(); // Åpner passordendringsvindu hvis innlogget.
                NyttPassordVindu.Show();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string brukernavn = txtBrukernavn.Text;
            string passord = txtPassord.Text;
            if (GlobaleVaraibler.rettBrukernavn == brukernavn && GlobaleVaraibler.rettPassord == passord)
            {
                string message = "Du er logget inn";
                string title = "Login";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                GlobaleVaraibler.on = true; // Setter innloggingsstatus til "true."
            }
            else
            {
                // Feil passord eller brukernavn
                string message = "Feil brukernavn eller passord, prøv igjen";
                string title = "Login";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            this.Hide(); // Skjuler hovedvinduet.
        }

        private void txtPassord_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string brukernavn = txtBrukernavn.Text;
                string passord = txtPassord.Text;
                if (GlobaleVaraibler.rettBrukernavn == brukernavn && GlobaleVaraibler.rettPassord == passord)
                {
                    string message = "Du er logget inn";
                    string title = "Login";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                    GlobaleVaraibler.on = true; // Setter innloggingsstatus til "true."
                }
                else
                {
                    // Feil passord eller brukernavn
                    string message = "Feil brukernavn eller passord, prøv igjen";
                    string title = "Login";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    txtPassord.Focus(); // Fokuserer på passordfeltet.
                }
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            fEndrePassord NyttPassordVindu = new fEndrePassord(); // Oppretter en instans av passordendringsvindu.
        }
    }
}
