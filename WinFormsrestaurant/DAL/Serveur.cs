using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WinFormsrestaurant.DAL
{
    public partial class Serveur
    {
        public Serveur()
        {
            Commande = new HashSet<Commande>();
        }

        public int IdServeur { get; set; }
        public string NomServeur { get; set; }
        public string PrenomServeur { get; set; }
        public byte? Actif { get; set; }

        public virtual ICollection<Commande> Commande { get; set; }
    }
}
