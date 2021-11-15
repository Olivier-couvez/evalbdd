using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WinFormsrestaurant.DAL;

namespace WinFormsrestaurant.Bll
{
    class BllCategorie
    {


        public List<Categoriearticle> getCategorie()
        {
            tpvrestaurantContext db = new tpvrestaurantContext();
            List<Categoriearticle> listearetourner = new List<Categoriearticle>();
            var format = from f in db.Categoriearticle select f;

            if (format.Count() > 0)
            {
                foreach (var elt in format)
                {
                    listearetourner.Add(elt);
                }
            }
            return listearetourner;
        }
        public bool AjouterCategorie(string designcat)
        {
            using tpvrestaurantContext db = new tpvrestaurantContext();
            Categoriearticle NouvelleCategorie = new Categoriearticle()
            {
                LibelleCatArticle = designcat
            };
            db.Categoriearticle.Add(NouvelleCategorie);
            db.SaveChanges();
            return true;
        }

        public bool supCat(int index)
        {
            using tpvrestaurantContext db = new tpvrestaurantContext();
            Categoriearticle SuppCate = new Categoriearticle()
            {
                IdCatArticle = index
            };
            db.Categoriearticle.Remove(SuppCate);
            db.SaveChanges();
            return true;
        }

        public bool ModificationCat(int index, string Libelle)
        {
            bool etat = false;
            try
            {
                tpvrestaurantContext db = new tpvrestaurantContext();
                Categoriearticle MajCat = new Categoriearticle()
                {
                    IdCatArticle = index,
                    LibelleCatArticle = Libelle
                };
                db.Categoriearticle.Update(MajCat);
                db.SaveChanges();
                etat = true;
            }
            catch
            {
                //erreur
            }
            return etat;
        }
    }
}
