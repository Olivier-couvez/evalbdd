using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WinFormsrestaurant.DAL
{
    public partial class Tablee
    {
        public Tablee()
        {
            Commande = new HashSet<Commande>();
        }

        public int NumTablee { get; set; }
        public int? NbPlaceTablee { get; set; }

        public virtual ICollection<Commande> Commande { get; set; }
    }
}
