using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using WinFormsrestaurant.Bll;
using WinFormsrestaurant.DAL;

namespace WinFormsrestaurant.Ihm
{
    public partial class GestCategorie : Form
    {
        DialogResult Fermeture;
        public GestCategorie()
        {
            InitializeComponent();
        }

        private void GestCategorie_Load(object sender, EventArgs e)
        {
            BllCategorie lectureFormation = new BllCategorie();
            dataGridCategorie.DataSource = lectureFormation.getCategorie();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            AjoutCategorie fenAjouterFormation = new AjoutCategorie();
            Fermeture = fenAjouterFormation.ShowDialog();
            if (Fermeture != DialogResult.OK)
            {
                MessageBox.Show("Création Catégorie faite !");
                using var db = new tpvrestaurantContext();
                dataGridCategorie.DataSource = db.Categoriearticle.ToList();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dataGridCategorie.CurrentRow.Cells[0].Value.ToString());
            BllCategorie bllCatSupp = new BllCategorie();
            bllCatSupp.supCat(index);
            using var db = new tpvrestaurantContext();
            dataGridCategorie.DataSource = db.Categoriearticle.ToList();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dataGridCategorie.CurrentRow.Cells[0].Value.ToString());
            BllCategorie bllModCat = new BllCategorie();
            bllModCat.ModificationCat(index, dataGridCategorie.CurrentRow.Cells[1].Value.ToString());
            using var db = new tpvrestaurantContext();
            dataGridCategorie.DataSource = db.Categoriearticle.ToList();
        }
    }
}
