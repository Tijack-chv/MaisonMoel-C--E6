using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Maison_moel.Entities;

public partial class BddMaisonMoelContext : DbContext
{
    public BddMaisonMoelContext()
    {
    }

    public BddMaisonMoelContext(DbContextOptions<BddMaisonMoelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Alergene> Alergenes { get; set; }

    public virtual DbSet<CategoriePlat> CategoriePlats { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Commande> Commandes { get; set; }

    public virtual DbSet<Comporter> Comporters { get; set; }

    public virtual DbSet<Cuisinier> Cuisiniers { get; set; }

    public virtual DbSet<Etat> Etats { get; set; }

    public virtual DbSet<Evenement> Evenements { get; set; }

    public virtual DbSet<Fournisseur> Fournisseurs { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Personne> Personnes { get; set; }

    public virtual DbSet<Plat> Plats { get; set; }

    public virtual DbSet<Produit> Produits { get; set; }

    public virtual DbSet<PromoMenu> PromoMenus { get; set; }

    public virtual DbSet<PromoPlat> PromoPlats { get; set; }

    public virtual DbSet<Reapprovisionnement> Reapprovisionnements { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<RoleCuisinier> RoleCuisiniers { get; set; }

    public virtual DbSet<Serveur> Serveurs { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TokenApi> TokenApis { get; set; }

    public virtual DbSet<TypeEvenement> TypeEvenements { get; set; }

    public virtual DbSet<TypeNotification> TypeNotifications { get; set; }

    public virtual DbSet<TypePlat> TypePlats { get; set; }

    public virtual DbSet<TypeProduit> TypeProduits { get; set; }

    public virtual DbSet<TypeTable> TypeTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.143.7;port=3306;user=admin-ap4;password=P@ssw0rd;database=bdd_maison_moel", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.40-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Idpersonne).HasName("PRIMARY");

            entity.ToTable("ADMIN");

            entity.Property(e => e.Idpersonne)
                .ValueGeneratedNever()
                .HasColumnName("IDPERSONNE");
            entity.Property(e => e.Datenaiss).HasColumnName("DATENAISS");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("NOM");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("PRENOM");
            entity.Property(e => e.Profiladmin).HasColumnName("PROFILADMIN");

            entity.HasOne(d => d.IdpersonneNavigation).WithOne(p => p.Admin)
                .HasForeignKey<Admin>(d => d.Idpersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ADMIN_ibfk_1");
        });

        modelBuilder.Entity<Alergene>(entity =>
        {
            entity.HasKey(e => e.Idalergenes).HasName("PRIMARY");

            entity.ToTable("ALERGENES");

            entity.Property(e => e.Idalergenes).HasColumnName("IDALERGENES");
            entity.Property(e => e.Descriptionalergenes)
                .HasMaxLength(128)
                .HasColumnName("DESCRIPTIONALERGENES");
        });

        modelBuilder.Entity<CategoriePlat>(entity =>
        {
            entity.HasKey(e => e.Idcategorieplat).HasName("PRIMARY");

            entity.ToTable("CATEGORIE_PLAT");

            entity.Property(e => e.Idcategorieplat).HasColumnName("IDCATEGORIEPLAT");
            entity.Property(e => e.Libellecategorieplat)
                .HasMaxLength(128)
                .HasColumnName("LIBELLECATEGORIEPLAT");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Idpersonne).HasName("PRIMARY");

            entity.ToTable("CLIENT");

            entity.Property(e => e.Idpersonne)
                .ValueGeneratedNever()
                .HasColumnName("IDPERSONNE");
            entity.Property(e => e.Datenaiss).HasColumnName("DATENAISS");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("NOM");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Pointfidelite).HasColumnName("POINTFIDELITE");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("PRENOM");

            entity.HasOne(d => d.IdpersonneNavigation).WithOne(p => p.Client)
                .HasForeignKey<Client>(d => d.Idpersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CLIENT_ibfk_1");
        });

        modelBuilder.Entity<Commande>(entity =>
        {
            entity.HasKey(e => e.Idcommande).HasName("PRIMARY");

            entity.ToTable("COMMANDE");

            entity.HasIndex(e => e.Idetat, "I_FK_COMMANDE_ETAT");

            entity.HasIndex(e => e.Idpersonne, "I_FK_COMMANDE_SERVEUR");

            entity.HasIndex(e => e.Idtable, "I_FK_COMMANDE_TABLES");

            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Datecommande)
                .HasColumnType("datetime")
                .HasColumnName("DATECOMMANDE");
            entity.Property(e => e.Idetat).HasColumnName("IDETAT");
            entity.Property(e => e.Idpersonne).HasColumnName("IDPERSONNE");
            entity.Property(e => e.Idtable).HasColumnName("IDTABLE");

            entity.HasOne(d => d.IdetatNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.Idetat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("COMMANDE_ibfk_1");

            entity.HasOne(d => d.IdpersonneNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.Idpersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("COMMANDE_ibfk_3");

            entity.HasOne(d => d.IdtableNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.Idtable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("COMMANDE_ibfk_2");
        });

        modelBuilder.Entity<Comporter>(entity =>
        {
            entity.HasKey(e => new { e.Idcommande, e.Idplat })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("COMPORTER");

            entity.HasIndex(e => e.Idcommande, "I_FK_COMPORTER_COMMANDE");

            entity.HasIndex(e => e.Idplat, "I_FK_COMPORTER_PLAT");

            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Idplat).HasColumnName("IDPLAT");
            entity.Property(e => e.Prix).HasColumnName("PRIX");

            entity.HasOne(d => d.IdcommandeNavigation).WithMany(p => p.Comporters)
                .HasForeignKey(d => d.Idcommande)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("COMPORTER_ibfk_1");

            entity.HasOne(d => d.IdplatNavigation).WithMany(p => p.Comporters)
                .HasForeignKey(d => d.Idplat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("COMPORTER_ibfk_2");
        });

        modelBuilder.Entity<Cuisinier>(entity =>
        {
            entity.HasKey(e => e.Idpersonne).HasName("PRIMARY");

            entity.ToTable("CUISINIER");

            entity.HasIndex(e => e.Idrole, "I_FK_CUISINIER_ROLE_CUISINIER");

            entity.Property(e => e.Idpersonne)
                .ValueGeneratedNever()
                .HasColumnName("IDPERSONNE");
            entity.Property(e => e.Datenaiss).HasColumnName("DATENAISS");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Idrole).HasColumnName("IDROLE");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("NOM");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("PRENOM");
            entity.Property(e => e.Salaires).HasColumnName("SALAIRES");

            entity.HasOne(d => d.IdpersonneNavigation).WithOne(p => p.Cuisinier)
                .HasForeignKey<Cuisinier>(d => d.Idpersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CUISINIER_ibfk_2");

            entity.HasOne(d => d.IdroleNavigation).WithMany(p => p.Cuisiniers)
                .HasForeignKey(d => d.Idrole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CUISINIER_ibfk_1");
        });

        modelBuilder.Entity<Etat>(entity =>
        {
            entity.HasKey(e => e.Idetat).HasName("PRIMARY");

            entity.ToTable("ETAT");

            entity.Property(e => e.Idetat).HasColumnName("IDETAT");
            entity.Property(e => e.Libelleetat)
                .HasMaxLength(128)
                .HasColumnName("LIBELLEETAT");
        });

        modelBuilder.Entity<Evenement>(entity =>
        {
            entity.HasKey(e => e.Idevenement).HasName("PRIMARY");

            entity.ToTable("EVENEMENT");

            entity.HasIndex(e => e.Idtypeevenement, "I_FK_EVENEMENT_TYPE_EVENEMENT");

            entity.Property(e => e.Idevenement).HasColumnName("IDEVENEMENT");
            entity.Property(e => e.Descritionevenement)
                .HasMaxLength(128)
                .HasColumnName("DESCRITIONEVENEMENT");
            entity.Property(e => e.Idtypeevenement).HasColumnName("IDTYPEEVENEMENT");
            entity.Property(e => e.Imageevenement)
                .HasMaxLength(128)
                .HasColumnName("IMAGEEVENEMENT");

            entity.HasOne(d => d.IdtypeevenementNavigation).WithMany(p => p.Evenements)
                .HasForeignKey(d => d.Idtypeevenement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EVENEMENT_ibfk_1");
        });

        modelBuilder.Entity<Fournisseur>(entity =>
        {
            entity.HasKey(e => e.Idfournisseur).HasName("PRIMARY");

            entity.ToTable("FOURNISSEUR");

            entity.Property(e => e.Idfournisseur).HasColumnName("IDFOURNISSEUR");
            entity.Property(e => e.Libellefournisseur)
                .HasMaxLength(128)
                .HasColumnName("LIBELLEFOURNISSEUR");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Idlogin).HasName("PRIMARY");

            entity.ToTable("LOG");

            entity.HasIndex(e => e.Idpersonne, "I_FK_LOG_PERSONNE");

            entity.Property(e => e.Idlogin).HasColumnName("IDLOGIN");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Idpersonne).HasColumnName("IDPERSONNE");

            entity.HasOne(d => d.IdpersonneNavigation).WithMany(p => p.Logs)
                .HasForeignKey(d => d.Idpersonne)
                .HasConstraintName("LOG_ibfk_1");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Idmenu).HasName("PRIMARY");

            entity.ToTable("MENU");

            entity.Property(e => e.Idmenu).HasColumnName("IDMENU");
            entity.Property(e => e.Libellemenu)
                .HasMaxLength(128)
                .HasColumnName("LIBELLEMENU");

            entity.HasMany(d => d.Idplats).WithMany(p => p.Idmenus)
                .UsingEntity<Dictionary<string, object>>(
                    "Constituer",
                    r => r.HasOne<Plat>().WithMany()
                        .HasForeignKey("Idplat")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("CONSTITUER_ibfk_2"),
                    l => l.HasOne<Menu>().WithMany()
                        .HasForeignKey("Idmenu")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("CONSTITUER_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idmenu", "Idplat")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("CONSTITUER");
                        j.HasIndex(new[] { "Idmenu" }, "I_FK_CONSTITUER_MENU");
                        j.HasIndex(new[] { "Idplat" }, "I_FK_CONSTITUER_PLAT");
                        j.IndexerProperty<int>("Idmenu").HasColumnName("IDMENU");
                        j.IndexerProperty<int>("Idplat").HasColumnName("IDPLAT");
                    });
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Idnotification).HasName("PRIMARY");

            entity.ToTable("NOTIFICATION");

            entity.HasIndex(e => e.Idtypenotification, "I_FK_NOTIFICATION_TYPE_NOTIFICATION");

            entity.Property(e => e.Idnotification).HasColumnName("IDNOTIFICATION");
            entity.Property(e => e.Descriptionnotification)
                .HasMaxLength(128)
                .HasColumnName("DESCRIPTIONNOTIFICATION");
            entity.Property(e => e.Idtypenotification).HasColumnName("IDTYPENOTIFICATION");

            entity.HasOne(d => d.IdtypenotificationNavigation).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.Idtypenotification)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("NOTIFICATION_ibfk_1");
        });

        modelBuilder.Entity<Personne>(entity =>
        {
            entity.HasKey(e => e.Idpersonne).HasName("PRIMARY");

            entity.ToTable("PERSONNE");

            entity.Property(e => e.Idpersonne).HasColumnName("IDPERSONNE");
            entity.Property(e => e.Datenaiss).HasColumnName("DATENAISS");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("NOM");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("PRENOM");
        });

        modelBuilder.Entity<Plat>(entity =>
        {
            entity.HasKey(e => e.Idplat).HasName("PRIMARY");

            entity.ToTable("PLAT");

            entity.HasIndex(e => e.Idcategorieplat, "I_FK_PLAT_CATEGORIE_PLAT");

            entity.HasIndex(e => e.Idtypeplat, "I_FK_PLAT_TYPE_PLAT");

            entity.Property(e => e.Idplat).HasColumnName("IDPLAT");
            entity.Property(e => e.Idcategorieplat).HasColumnName("IDCATEGORIEPLAT");
            entity.Property(e => e.Idtypeplat).HasColumnName("IDTYPEPLAT");
            entity.Property(e => e.Nomplat)
                .HasMaxLength(128)
                .HasColumnName("NOMPLAT");

            entity.HasOne(d => d.IdcategorieplatNavigation).WithMany(p => p.Plats)
                .HasForeignKey(d => d.Idcategorieplat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PLAT_ibfk_1");

            entity.HasOne(d => d.IdtypeplatNavigation).WithMany(p => p.Plats)
                .HasForeignKey(d => d.Idtypeplat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PLAT_ibfk_2");

            entity.HasMany(d => d.Idproduits).WithMany(p => p.Idplats)
                .UsingEntity<Dictionary<string, object>>(
                    "Composer",
                    r => r.HasOne<Produit>().WithMany()
                        .HasForeignKey("Idproduit")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("COMPOSER_ibfk_2"),
                    l => l.HasOne<Plat>().WithMany()
                        .HasForeignKey("Idplat")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("COMPOSER_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idplat", "Idproduit")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("COMPOSER");
                        j.HasIndex(new[] { "Idplat" }, "I_FK_COMPOSER_PLAT");
                        j.HasIndex(new[] { "Idproduit" }, "I_FK_COMPOSER_PRODUIT");
                        j.IndexerProperty<int>("Idplat").HasColumnName("IDPLAT");
                        j.IndexerProperty<int>("Idproduit").HasColumnName("IDPRODUIT");
                    });
        });

        modelBuilder.Entity<Produit>(entity =>
        {
            entity.HasKey(e => e.Idproduit).HasName("PRIMARY");

            entity.ToTable("PRODUIT");

            entity.HasIndex(e => e.Idtypeproduit, "FK_TYPE_PRODUIT");

            entity.Property(e => e.Idproduit).HasColumnName("IDPRODUIT");
            entity.Property(e => e.Descriptionproduit)
                .HasMaxLength(128)
                .HasColumnName("DESCRIPTIONPRODUIT");
            entity.Property(e => e.Idtypeproduit).HasColumnName("IDTYPEPRODUIT");
            entity.Property(e => e.Prixht).HasColumnName("PRIXHT");
            entity.Property(e => e.Quantite).HasColumnName("QUANTITE");
            entity.Property(e => e.Titreproduit)
                .HasMaxLength(128)
                .HasColumnName("TITREPRODUIT");

            entity.HasOne(d => d.IdtypeproduitNavigation).WithMany(p => p.Produits)
                .HasForeignKey(d => d.Idtypeproduit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TYPE_PRODUIT");

            entity.HasMany(d => d.Idalergenes).WithMany(p => p.Idproduits)
                .UsingEntity<Dictionary<string, object>>(
                    "Restreindre",
                    r => r.HasOne<Alergene>().WithMany()
                        .HasForeignKey("Idalergenes")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("RESTREINDRE_ibfk_2"),
                    l => l.HasOne<Produit>().WithMany()
                        .HasForeignKey("Idproduit")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("RESTREINDRE_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idproduit", "Idalergenes")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("RESTREINDRE");
                        j.HasIndex(new[] { "Idalergenes" }, "I_FK_RESTREINDRE_ALERGENES");
                        j.HasIndex(new[] { "Idproduit" }, "I_FK_RESTREINDRE_PRODUIT");
                        j.IndexerProperty<int>("Idproduit").HasColumnName("IDPRODUIT");
                        j.IndexerProperty<int>("Idalergenes").HasColumnName("IDALERGENES");
                    });
        });

        modelBuilder.Entity<PromoMenu>(entity =>
        {
            entity.HasKey(e => new { e.Idevenement, e.Idmenu })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("PROMO_MENU");

            entity.HasIndex(e => e.Idevenement, "I_FK_PROMO_MENU_EVENEMENT");

            entity.HasIndex(e => e.Idmenu, "I_FK_PROMO_MENU_MENU");

            entity.Property(e => e.Idevenement).HasColumnName("IDEVENEMENT");
            entity.Property(e => e.Idmenu).HasColumnName("IDMENU");
            entity.Property(e => e.Datedebut)
                .HasColumnType("datetime")
                .HasColumnName("DATEDEBUT");
            entity.Property(e => e.Datefin)
                .HasColumnType("datetime")
                .HasColumnName("DATEFIN");

            entity.HasOne(d => d.IdevenementNavigation).WithMany(p => p.PromoMenus)
                .HasForeignKey(d => d.Idevenement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PROMO_MENU_ibfk_1");

            entity.HasOne(d => d.IdmenuNavigation).WithMany(p => p.PromoMenus)
                .HasForeignKey(d => d.Idmenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PROMO_MENU_ibfk_2");
        });

        modelBuilder.Entity<PromoPlat>(entity =>
        {
            entity.HasKey(e => new { e.Idevenement, e.Idplat })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("PROMO_PLAT");

            entity.HasIndex(e => e.Idevenement, "I_FK_PROMO_PLAT_EVENEMENT");

            entity.HasIndex(e => e.Idplat, "I_FK_PROMO_PLAT_PLAT");

            entity.Property(e => e.Idevenement).HasColumnName("IDEVENEMENT");
            entity.Property(e => e.Idplat).HasColumnName("IDPLAT");
            entity.Property(e => e.Datedebut)
                .HasColumnType("datetime")
                .HasColumnName("DATEDEBUT");
            entity.Property(e => e.Datefin)
                .HasColumnType("datetime")
                .HasColumnName("DATEFIN");

            entity.HasOne(d => d.IdevenementNavigation).WithMany(p => p.PromoPlats)
                .HasForeignKey(d => d.Idevenement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PROMO_PLAT_ibfk_1");

            entity.HasOne(d => d.IdplatNavigation).WithMany(p => p.PromoPlats)
                .HasForeignKey(d => d.Idplat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PROMO_PLAT_ibfk_2");
        });

        modelBuilder.Entity<Reapprovisionnement>(entity =>
        {
            entity.HasKey(e => new { e.Idproduit, e.Idfournisseur, e.Dateheurereapro })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("REAPPROVISIONNEMENT");

            entity.HasIndex(e => e.Idfournisseur, "I_FK_REAPPROVISIONNEMENT_FOURNISSEUR");

            entity.HasIndex(e => e.Idproduit, "I_FK_REAPPROVISIONNEMENT_PRODUIT");

            entity.Property(e => e.Idproduit).HasColumnName("IDPRODUIT");
            entity.Property(e => e.Idfournisseur).HasColumnName("IDFOURNISSEUR");
            entity.Property(e => e.Dateheurereapro)
                .HasColumnType("datetime")
                .HasColumnName("DATEHEUREREAPRO");
            entity.Property(e => e.Quantitecommande).HasColumnName("QUANTITECOMMANDE");

            entity.HasOne(d => d.IdfournisseurNavigation).WithMany(p => p.Reapprovisionnements)
                .HasForeignKey(d => d.Idfournisseur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REAPPROVISIONNEMENT_ibfk_2");

            entity.HasOne(d => d.IdproduitNavigation).WithMany(p => p.Reapprovisionnements)
                .HasForeignKey(d => d.Idproduit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REAPPROVISIONNEMENT_ibfk_1");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => new { e.Idpersonne, e.Dateheureres, e.Idtable })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("RESERVATION");

            entity.HasIndex(e => e.Idpersonne, "I_FK_RESERVATION_CLIENT");

            entity.HasIndex(e => e.Idtable, "I_FK_RESERVATION_TABLES");

            entity.Property(e => e.Idpersonne).HasColumnName("IDPERSONNE");
            entity.Property(e => e.Dateheureres)
                .HasColumnType("datetime")
                .HasColumnName("DATEHEURERES");
            entity.Property(e => e.Idtable).HasColumnName("IDTABLE");
            entity.Property(e => e.Nbpersonnes).HasColumnName("NBPERSONNES");

            entity.HasOne(d => d.IdpersonneNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.Idpersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RESERVATION_ibfk_1");

            entity.HasOne(d => d.IdtableNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.Idtable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RESERVATION_ibfk_2");
        });

        modelBuilder.Entity<RoleCuisinier>(entity =>
        {
            entity.HasKey(e => e.Idrole).HasName("PRIMARY");

            entity.ToTable("ROLE_CUISINIER");

            entity.Property(e => e.Idrole).HasColumnName("IDROLE");
            entity.Property(e => e.Libellerole)
                .HasMaxLength(128)
                .HasColumnName("LIBELLEROLE");
        });

        modelBuilder.Entity<Serveur>(entity =>
        {
            entity.HasKey(e => e.Idpersonne).HasName("PRIMARY");

            entity.ToTable("SERVEUR");

            entity.Property(e => e.Idpersonne)
                .ValueGeneratedNever()
                .HasColumnName("IDPERSONNE");
            entity.Property(e => e.Appreciations).HasColumnName("APPRECIATIONS");
            entity.Property(e => e.Datenaiss).HasColumnName("DATENAISS");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("NOM");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("PRENOM");
            entity.Property(e => e.Salaires).HasColumnName("SALAIRES");

            entity.HasOne(d => d.IdpersonneNavigation).WithOne(p => p.Serveur)
                .HasForeignKey<Serveur>(d => d.Idpersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SERVEUR_ibfk_1");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Idtable).HasName("PRIMARY");

            entity.ToTable("TABLES");

            entity.HasIndex(e => e.Idtypetable, "I_FK_TABLES_TYPE_TABLE");

            entity.Property(e => e.Idtable).HasColumnName("IDTABLE");
            entity.Property(e => e.Idtypetable).HasColumnName("IDTYPETABLE");
            entity.Property(e => e.Nomtable)
                .HasMaxLength(128)
                .HasColumnName("NOMTABLE");

            entity.HasOne(d => d.IdtypetableNavigation).WithMany(p => p.Tables)
                .HasForeignKey(d => d.Idtypetable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TABLES_ibfk_1");
        });

        modelBuilder.Entity<TokenApi>(entity =>
        {
            entity.HasKey(e => e.Token).HasName("PRIMARY");

            entity.ToTable("TOKEN_API");

            entity.Property(e => e.Token)
                .HasMaxLength(250)
                .HasColumnName("token");
        });

        modelBuilder.Entity<TypeEvenement>(entity =>
        {
            entity.HasKey(e => e.Idtypeevenement).HasName("PRIMARY");

            entity.ToTable("TYPE_EVENEMENT");

            entity.Property(e => e.Idtypeevenement).HasColumnName("IDTYPEEVENEMENT");
            entity.Property(e => e.Libelletypeevenement)
                .HasMaxLength(128)
                .HasColumnName("LIBELLETYPEEVENEMENT");
        });

        modelBuilder.Entity<TypeNotification>(entity =>
        {
            entity.HasKey(e => e.Idtypenotification).HasName("PRIMARY");

            entity.ToTable("TYPE_NOTIFICATION");

            entity.Property(e => e.Idtypenotification).HasColumnName("IDTYPENOTIFICATION");
            entity.Property(e => e.Libelletypenotification)
                .HasMaxLength(128)
                .HasColumnName("LIBELLETYPENOTIFICATION");
        });

        modelBuilder.Entity<TypePlat>(entity =>
        {
            entity.HasKey(e => e.Idtypeplat).HasName("PRIMARY");

            entity.ToTable("TYPE_PLAT");

            entity.Property(e => e.Idtypeplat).HasColumnName("IDTYPEPLAT");
            entity.Property(e => e.Libelletypeplat)
                .HasMaxLength(128)
                .HasColumnName("LIBELLETYPEPLAT");
        });

        modelBuilder.Entity<TypeProduit>(entity =>
        {
            entity.HasKey(e => e.Idtypeproduit).HasName("PRIMARY");

            entity.ToTable("TYPE_PRODUIT");

            entity.Property(e => e.Idtypeproduit).HasColumnName("IDTYPEPRODUIT");
            entity.Property(e => e.Libelletypeproduit)
                .HasMaxLength(128)
                .HasColumnName("LIBELLETYPEPRODUIT");
        });

        modelBuilder.Entity<TypeTable>(entity =>
        {
            entity.HasKey(e => e.Idtypetable).HasName("PRIMARY");

            entity.ToTable("TYPE_TABLE");

            entity.Property(e => e.Idtypetable)
                .ValueGeneratedNever()
                .HasColumnName("IDTYPETABLE");
            entity.Property(e => e.Libelletypeplat)
                .HasMaxLength(128)
                .HasColumnName("LIBELLETYPEPLAT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
