using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WinFormsrestaurant.DAL
{
    public partial class Commande
    {
        public Commande()
        {
            Qtearticle = new HashSet<Qtearticle>();
        }

        public int NumCommande { get; set; }
        public byte? Termine { get; set; }
        public int IdServeurFk { get; set; }
        public int NumTableeFk { get; set; }

        public virtual Serveur IdServeurFkNavigation { get; set; }
        public virtual Tablee NumTableeFkNavigation { get; set; }
        public virtual ICollection<Qtearticle> Qtearticle { get; set; }
    }
}
