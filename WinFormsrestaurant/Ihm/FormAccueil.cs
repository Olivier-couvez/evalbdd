using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsrestaurant.Ihm;
using WinFormsrestaurant.DAL;

namespace WinFormsrestaurant
{
    public partial class FormAccueil : Form
    {
        DialogResult Fermeture;
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void btnGestCarte_Click(object sender, EventArgs e)
        {
            GestionCarte fencarte = new GestionCarte();
            Fermeture = fencarte.ShowDialog();

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
