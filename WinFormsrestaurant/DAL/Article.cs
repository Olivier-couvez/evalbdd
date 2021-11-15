using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WinFormsrestaurant.DAL
{
    public partial class Article
    {
        public Article()
        {
            Qtearticle = new HashSet<Qtearticle>();
        }

        public int IdArticle { get; set; }
        public string DesignationArticle { get; set; }
        public decimal? PrixArticle { get; set; }
        public string PhotoArticle { get; set; }
        public int? IdCategorieArticleFk { get; set; }

        public virtual Categoriearticle IdCategorieArticleFkNavigation { get; set; }
        public virtual ICollection<Qtearticle> Qtearticle { get; set; }
    }
}
