using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WinFormsrestaurant.DAL;

namespace WinFormsrestaurant.Bll
{
    class BllArticle
    {

        public List<Article> getArticle()
        {
            tpvrestaurantContext db = new tpvrestaurantContext();
            List<Article> listearetourner = new List<Article>();
            var format = from f in db.Article select f;

            if (format.Count() > 0)
            {
                foreach (var elt in format)
                {
                    listearetourner.Add(elt);
                }
            }
            return listearetourner;
        }
        public bool AjouterArticle(string designart, int prixart, string photoart, int idcatart)
        {
            using tpvrestaurantContext db = new tpvrestaurantContext();
            Article Nouveauarticle = new Article()
            {
                DesignationArticle = designart,
                PrixArticle = prixart,
                PhotoArticle = photoart,
                IdCategorieArticleFk = idcatart
            };
            db.Article.Add(Nouveauarticle);
            db.SaveChanges();
            return true;
        }
    }
}
