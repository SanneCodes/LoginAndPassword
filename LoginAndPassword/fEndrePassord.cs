using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VS.Del3_Sanne.fMain;

namespace VS.Del3_Sanne
{
    public partial class fEndrePassord : Form
    {
        public fEndrePassord()
        {
            InitializeComponent();
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            GlobaleVaraibler.rettPassord = txtNyttPassord.Text;
            if (GlobaleVaraibler.rettPassord == txtNyttPassord.Text)
            {
                string message = "Du har endret passordet" + Environment.NewLine +
               "Dette vinduet blir lukket! ";
                string title = "Nytt Passord!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons,
               MessageBoxIcon.Information);
                //this.Close();
                this.Hide();
            }

        }

        private void btnAngre_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
