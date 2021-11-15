using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WinFormsrestaurant.DAL
{
    public partial class tpvrestaurantContext : DbContext
    {
        public tpvrestaurantContext()
        {
        }

        public tpvrestaurantContext(DbContextOptions<tpvrestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Categoriearticle> Categoriearticle { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Qtearticle> Qtearticle { get; set; }
        public virtual DbSet<Sdf> Sdf { get; set; }
        public virtual DbSet<Serveur> Serveur { get; set; }
        public virtual DbSet<Tablee> Tablee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=tpvrestaurant");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.IdArticle)
                    .HasName("PRIMARY");

                entity.ToTable("article");

                entity.HasIndex(e => e.IdCategorieArticleFk)
                    .HasName("fk_Article_CategorieArticle1_idx");

                entity.Property(e => e.IdArticle)
                    .HasColumnName("idArticle")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DesignationArticle)
                    .HasColumnName("designationArticle")
                    .HasMaxLength(45);

                entity.Property(e => e.IdCategorieArticleFk)
                    .HasColumnName("idCategorieArticleFK")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PhotoArticle)
                    .HasColumnName("photoArticle")
                    .HasMaxLength(45);

                entity.Property(e => e.PrixArticle)
                    .HasColumnName("prixArticle")
                    .HasColumnType("decimal(10,0)");

                entity.HasOne(d => d.IdCategorieArticleFkNavigation)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.IdCategorieArticleFk)
                    .HasConstraintName("fk_Article_CategorieArticle1");
            });

            modelBuilder.Entity<Categoriearticle>(entity =>
            {
                entity.HasKey(e => e.IdCatArticle)
                    .HasName("PRIMARY");

                entity.ToTable("categoriearticle");

                entity.Property(e => e.IdCatArticle)
                    .HasColumnName("idCatArticle")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibelleCatArticle)
                    .HasColumnName("libelleCatArticle")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.NumCommande)
                    .HasName("PRIMARY");

                entity.ToTable("commande");

                entity.HasIndex(e => e.IdServeurFk)
                    .HasName("fk_Commande_Serveur_idx");

                entity.HasIndex(e => e.NumTableeFk)
                    .HasName("fk_Commande_tablee1_idx");

                entity.Property(e => e.NumCommande)
                    .HasColumnName("numCommande")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdServeurFk)
                    .HasColumnName("idServeurFK")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumTableeFk)
                    .HasColumnName("numTableeFK")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Termine)
                    .HasColumnName("termine")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.IdServeurFkNavigation)
                    .WithMany(p => p.Commande)
                    .HasForeignKey(d => d.IdServeurFk)
                    .HasConstraintName("fk_Commande_Serveur");

                entity.HasOne(d => d.NumTableeFkNavigation)
                    .WithMany(p => p.Commande)
                    .HasForeignKey(d => d.NumTableeFk)
                    .HasConstraintName("fk_Commande_tablee1");
            });

            modelBuilder.Entity<Qtearticle>(entity =>
            {
                entity.HasKey(e => new { e.CommandeNumCommande, e.IdArticle })
                    .HasName("PRIMARY");

                entity.ToTable("qtearticle");

                entity.HasIndex(e => e.CommandeNumCommande)
                    .HasName("fk_Commande_has_Article_Commande1_idx");

                entity.HasIndex(e => e.IdArticle)
                    .HasName("fk_Commande_has_Article_Article1_idx");

                entity.Property(e => e.CommandeNumCommande)
                    .HasColumnName("Commande_numCommande")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdArticle)
                    .HasColumnName("idArticle")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qte).HasColumnType("int(11)");

                entity.HasOne(d => d.CommandeNumCommandeNavigation)
                    .WithMany(p => p.Qtearticle)
                    .HasForeignKey(d => d.CommandeNumCommande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Commande_has_Article_Commande1");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.Qtearticle)
                    .HasForeignKey(d => d.IdArticle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Commande_has_Article_Article1");
            });

            modelBuilder.Entity<Sdf>(entity =>
            {
                entity.HasKey(e => e.Igh)
                    .HasName("PRIMARY");

                entity.ToTable("sdf");

                entity.Property(e => e.Igh)
                    .HasColumnName("igh")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Serveur>(entity =>
            {
                entity.HasKey(e => e.IdServeur)
                    .HasName("PRIMARY");

                entity.ToTable("serveur");

                entity.Property(e => e.IdServeur)
                    .HasColumnName("idServeur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Actif)
                    .HasColumnName("actif")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.NomServeur)
                    .HasColumnName("nomServeur")
                    .HasMaxLength(45);

                entity.Property(e => e.PrenomServeur)
                    .HasColumnName("prenomServeur")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Tablee>(entity =>
            {
                entity.HasKey(e => e.NumTablee)
                    .HasName("PRIMARY");

                entity.ToTable("tablee");

                entity.Property(e => e.NumTablee)
                    .HasColumnName("numTablee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NbPlaceTablee)
                    .HasColumnName("nbPlaceTablee")
                    .HasColumnType("int(45)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
