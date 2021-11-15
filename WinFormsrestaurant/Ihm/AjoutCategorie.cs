using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsrestaurant.Bll;


namespace WinFormsrestaurant.Ihm
{
    public partial class AjoutCategorie : Form
    {
        public AjoutCategorie()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            BllCategorie nouvelleCat = new BllCategorie();
            nouvelleCat.AjouterCategorie(textBoxLib.Text);
            this.Close();
        }
    }
}
