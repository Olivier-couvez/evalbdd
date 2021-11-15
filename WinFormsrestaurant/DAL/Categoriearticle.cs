using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WinFormsrestaurant.DAL
{
    public partial class Categoriearticle
    {
        public Categoriearticle()
        {
            Article = new HashSet<Article>();
        }

        public int IdCatArticle { get; set; }
        public string LibelleCatArticle { get; set; }

        public virtual ICollection<Article> Article { get; set; }
    }
}
