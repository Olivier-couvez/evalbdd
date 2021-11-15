using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using WinFormsrestaurant.Bll;
using WinFormsrestaurant.DAL;

namespace WinFormsrestaurant.Ihm
{
    public partial class GestionCarte : Form
    {
        DialogResult Fermeture;
        public GestionCarte()
        {
            InitializeComponent();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            GestCategorie fencarte = new GestCategorie();
            Fermeture = fencarte.ShowDialog();
        }

        private void btnaccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionCarte_Load(object sender, EventArgs e)
        {
            BllArticle lectureArticle = new BllArticle();
            dataGridCarte.DataSource = lectureArticle.getArticle();
        }
    }
}
