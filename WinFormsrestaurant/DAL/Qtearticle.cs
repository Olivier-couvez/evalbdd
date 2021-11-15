using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WinFormsrestaurant.DAL
{
    public partial class Qtearticle
    {
        public int CommandeNumCommande { get; set; }
        public int IdArticle { get; set; }
        public int? Qte { get; set; }

        public virtual Commande CommandeNumCommandeNavigation { get; set; }
        public virtual Article IdArticleNavigation { get; set; }
    }
}
