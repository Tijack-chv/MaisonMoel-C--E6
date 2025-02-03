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

    public virtual DbSet<Avi> Avis { get; set; }

    public virtual DbSet<CategoriePlat> CategoriePlats { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Commande> Commandes { get; set; }

    public virtual DbSet<Comporter> Comporters { get; set; }

    public virtual DbSet<Cuisinier> Cuisiniers { get; set; }

    public virtual DbSet<Dechet> Dechets { get; set; }

    public virtual DbSet<Etat> Etats { get; set; }

    public virtual DbSet<Evenement> Evenements { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Personne> Personnes { get; set; }

    public virtual DbSet<Plat> Plats { get; set; }

    public virtual DbSet<PromoPlat> PromoPlats { get; set; }

    public virtual DbSet<Reapprovisionnement> Reapprovisionnements { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<RoleCuisinier> RoleCuisiniers { get; set; }

    public virtual DbSet<Serveur> Serveurs { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TokenApi> TokenApis { get; set; }

    public virtual DbSet<TokenUserApi> TokenUserApis { get; set; }

    public virtual DbSet<TypeEvenement> TypeEvenements { get; set; }

    public virtual DbSet<TypeNotification> TypeNotifications { get; set; }

    public virtual DbSet<TypePlat> TypePlats { get; set; }

    public virtual DbSet<TypeTable> TypeTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.143.12;port=3306;user=admin-ap4;password=P@ssw0rd;database=BDD_MaisonMoel", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.4.4-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdPersonne).HasName("PRIMARY");

            entity.ToTable("admin");

            entity.Property(e => e.IdPersonne)
                .ValueGeneratedNever()
                .HasColumnName("idPersonne");
            entity.Property(e => e.ProfilAdmin).HasColumnName("profilAdmin");

            entity.HasOne(d => d.IdPersonneNavigation).WithOne(p => p.Admin)
                .HasForeignKey<Admin>(d => d.IdPersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("admin_ibfk_1");
        });

        modelBuilder.Entity<Alergene>(entity =>
        {
            entity.HasKey(e => e.IdAlergenes).HasName("PRIMARY");

            entity.ToTable("alergenes");

            entity.Property(e => e.IdAlergenes).HasColumnName("idAlergenes");
            entity.Property(e => e.DescriptionAlergenes)
                .HasMaxLength(128)
                .HasColumnName("descriptionAlergenes");

            entity.HasMany(d => d.IdPlats).WithMany(p => p.IdAlergenes)
                .UsingEntity<Dictionary<string, object>>(
                    "Restreindre",
                    r => r.HasOne<Plat>().WithMany()
                        .HasForeignKey("IdPlat")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("plat_ibfk_22"),
                    l => l.HasOne<Alergene>().WithMany()
                        .HasForeignKey("IdAlergenes")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("aler_ibfk_1"),
                    j =>
                    {
                        j.HasKey("IdAlergenes", "IdPlat")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("restreindre");
                        j.HasIndex(new[] { "IdAlergenes" }, "I_FK_restreindre_alergenes");
                        j.HasIndex(new[] { "IdPlat" }, "I_FK_restreindre_plat");
                        j.IndexerProperty<int>("IdAlergenes").HasColumnName("idAlergenes");
                        j.IndexerProperty<int>("IdPlat").HasColumnName("idPlat");
                    });
        });

        modelBuilder.Entity<Avi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("avis");

            entity.HasIndex(e => e.IdPersonne, "FK_IDPERSONNE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description)
                .HasMaxLength(2047)
                .HasColumnName("description");
            entity.Property(e => e.IdPersonne).HasColumnName("idPersonne");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Titre)
                .HasMaxLength(127)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdPersonneNavigation).WithMany(p => p.Avis)
                .HasForeignKey(d => d.IdPersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IDPERSONNE");
        });

        modelBuilder.Entity<CategoriePlat>(entity =>
        {
            entity.HasKey(e => e.IdCategoriePlat).HasName("PRIMARY");

            entity.ToTable("categorie_plat");

            entity.Property(e => e.IdCategoriePlat).HasColumnName("idCategoriePlat");
            entity.Property(e => e.LibelleCategoriePlat)
                .HasMaxLength(128)
                .HasColumnName("libelleCategoriePlat");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdPersonne).HasName("PRIMARY");

            entity.ToTable("client");

            entity.Property(e => e.IdPersonne)
                .ValueGeneratedNever()
                .HasColumnName("idPersonne");
            entity.Property(e => e.ImageClient)
                .HasMaxLength(127)
                .HasColumnName("imageClient");
            entity.Property(e => e.PointFidelite).HasColumnName("pointFidelite");
        });

        modelBuilder.Entity<Commande>(entity =>
        {
            entity.HasKey(e => e.IdCommande).HasName("PRIMARY");

            entity.ToTable("commande");

            entity.HasIndex(e => e.IdEtat, "I_FK_commande_etat");

            entity.HasIndex(e => e.IdReservation, "I_FK_commande_reservation");

            entity.HasIndex(e => e.IdPersonne, "I_FK_commande_serveur");

            entity.Property(e => e.IdCommande).HasColumnName("idCommande");
            entity.Property(e => e.DateCommande)
                .HasColumnType("datetime")
                .HasColumnName("dateCommande");
            entity.Property(e => e.EstPayer).HasColumnName("est_payer");
            entity.Property(e => e.IdEtat).HasColumnName("idEtat");
            entity.Property(e => e.IdPersonne).HasColumnName("idPersonne");
            entity.Property(e => e.IdReservation).HasColumnName("idReservation");

            entity.HasOne(d => d.IdEtatNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.IdEtat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("commande_ibfk_1");

            entity.HasOne(d => d.IdPersonneNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.IdPersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("serv_ibfk_1");

            entity.HasOne(d => d.IdReservationNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.IdReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("reserv_ibfk_1");
        });

        modelBuilder.Entity<Comporter>(entity =>
        {
            entity.HasKey(e => new { e.IdCommande, e.IdPlat })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("comporter");

            entity.HasIndex(e => e.IdCommande, "I_FK_comporter_commande");

            entity.HasIndex(e => e.IdPlat, "I_FK_comporter_plat");

            entity.HasIndex(e => e.IdEtat, "idEtat");

            entity.Property(e => e.IdCommande).HasColumnName("idCommande");
            entity.Property(e => e.IdPlat).HasColumnName("idPlat");
            entity.Property(e => e.IdEtat)
                .HasDefaultValueSql("'1'")
                .HasColumnName("idEtat");
            entity.Property(e => e.NbCommander).HasColumnName("nbCommander");
            entity.Property(e => e.Prix)
                .HasPrecision(10, 2)
                .HasColumnName("prix");

            entity.HasOne(d => d.IdCommandeNavigation).WithMany(p => p.Comporters)
                .HasForeignKey(d => d.IdCommande)
                .HasConstraintName("comm_ibfk_1");

            entity.HasOne(d => d.IdEtatNavigation).WithMany(p => p.Comporters)
                .HasForeignKey(d => d.IdEtat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("comporter_ibfk_1");

            entity.HasOne(d => d.IdPlatNavigation).WithMany(p => p.Comporters)
                .HasForeignKey(d => d.IdPlat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pla_ibfk_1");
        });

        modelBuilder.Entity<Cuisinier>(entity =>
        {
            entity.HasKey(e => e.IdPersonne).HasName("PRIMARY");

            entity.ToTable("cuisinier");

            entity.HasIndex(e => e.IdRole, "I_FK_cuisinier_role_cuisinier");

            entity.Property(e => e.IdPersonne)
                .ValueGeneratedNever()
                .HasColumnName("idPersonne");
            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.Salaires).HasColumnName("salaires");

            entity.HasOne(d => d.IdPersonneNavigation).WithOne(p => p.Cuisinier)
                .HasForeignKey<Cuisinier>(d => d.IdPersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cuisinier_ibfk_2");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Cuisiniers)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("cuisinier_ibfk_1");
        });

        modelBuilder.Entity<Dechet>(entity =>
        {
            entity.HasKey(e => e.IdDechets).HasName("PRIMARY");

            entity.ToTable("dechets");

            entity.Property(e => e.IdDechets).HasColumnName("idDechets");
            entity.Property(e => e.DateSaisie)
                .HasColumnType("datetime")
                .HasColumnName("dateSaisie");
            entity.Property(e => e.Poids).HasColumnName("poids");
        });

        modelBuilder.Entity<Etat>(entity =>
        {
            entity.HasKey(e => e.IdEtat).HasName("PRIMARY");

            entity.ToTable("etat");

            entity.Property(e => e.IdEtat).HasColumnName("idEtat");
            entity.Property(e => e.LibelleEtat)
                .HasMaxLength(128)
                .HasColumnName("libelleEtat");
        });

        modelBuilder.Entity<Evenement>(entity =>
        {
            entity.HasKey(e => e.IdEvenement).HasName("PRIMARY");

            entity.ToTable("evenement");

            entity.HasIndex(e => e.IdTypeEvenement, "I_FK_evenement_type_evenement");

            entity.Property(e => e.IdEvenement).HasColumnName("idEvenement");
            entity.Property(e => e.DescriptionEvenement)
                .HasMaxLength(128)
                .HasColumnName("descriptionEvenement");
            entity.Property(e => e.IdTypeEvenement).HasColumnName("idTypeEvenement");
            entity.Property(e => e.ImageEvenement)
                .HasMaxLength(128)
                .HasColumnName("imageEvenement");

            entity.HasOne(d => d.IdTypeEvenementNavigation).WithMany(p => p.Evenements)
                .HasForeignKey(d => d.IdTypeEvenement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("evenement_ibfk_1");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PRIMARY");

            entity.ToTable("log");

            entity.Property(e => e.IdLog).HasColumnName("idLog");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("message");

            entity.HasIndex(e => e.IdPersonne, "FK_IDPERSONNE_MESSAGE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EstVue).HasColumnName("estVue");
            entity.Property(e => e.IdPersonne).HasColumnName("idPersonne");
            entity.Property(e => e.Message1)
                .HasMaxLength(512)
                .HasColumnName("message");

            entity.HasOne(d => d.IdPersonneNavigation).WithMany(p => p.Messages)
                .HasForeignKey(d => d.IdPersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IDPERSONNE_MESSAGE");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.IdNotification).HasName("PRIMARY");

            entity.ToTable("notification");

            entity.HasIndex(e => e.IdTypeNotification, "I_FK_notification_type_notification");

            entity.Property(e => e.IdNotification).HasColumnName("idNotification");
            entity.Property(e => e.DescriptionNotification)
                .HasMaxLength(128)
                .HasColumnName("descriptionNotification");
            entity.Property(e => e.IdTypeNotification).HasColumnName("idTypeNotification");

            entity.HasOne(d => d.IdTypeNotificationNavigation).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.IdTypeNotification)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("typnotif_ibfk_1");
        });

        modelBuilder.Entity<Personne>(entity =>
        {
            entity.HasKey(e => e.IdPersonne).HasName("PRIMARY");

            entity.ToTable("personne");

            entity.HasIndex(e => e.Email, "uniq_email").IsUnique();

            entity.Property(e => e.IdPersonne).HasColumnName("idPersonne");
            entity.Property(e => e.Archiver).HasColumnName("archiver");
            entity.Property(e => e.DateNaiss).HasColumnName("dateNaiss");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("email");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("nom");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("prenom");
            entity.Property(e => e.Token)
                .HasMaxLength(100)
                .HasColumnName("token");
        });

        modelBuilder.Entity<Plat>(entity =>
        {
            entity.HasKey(e => e.IdPlat).HasName("PRIMARY");

            entity.ToTable("plat");

            entity.HasIndex(e => e.IdCategoriePlat, "I_FK_plat_categorie_plat");

            entity.HasIndex(e => e.IdTypePlat, "I_FK_plat_type_plat");

            entity.HasIndex(e => e.ImagePlat, "imageUniqPlat").IsUnique();

            entity.Property(e => e.IdPlat).HasColumnName("idPlat");
            entity.Property(e => e.DescriptionPlat)
                .HasMaxLength(128)
                .HasColumnName("descriptionPlat");
            entity.Property(e => e.IdCategoriePlat).HasColumnName("idCategoriePlat");
            entity.Property(e => e.IdTypePlat).HasColumnName("idTypePlat");
            entity.Property(e => e.ImagePlat)
                .HasMaxLength(128)
                .HasColumnName("imagePlat");
            entity.Property(e => e.NomPlat)
                .HasMaxLength(128)
                .HasColumnName("nomPlat");
            entity.Property(e => e.PrixHt)
                .HasPrecision(10, 2)
                .HasColumnName("prixHT");
            entity.Property(e => e.Quantite).HasColumnName("quantite");

            entity.HasOne(d => d.IdCategoriePlatNavigation).WithMany(p => p.Plats)
                .HasForeignKey(d => d.IdCategoriePlat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plat_ibfk_1");

            entity.HasOne(d => d.IdTypePlatNavigation).WithMany(p => p.Plats)
                .HasForeignKey(d => d.IdTypePlat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plat_ibfk_2");
        });

        modelBuilder.Entity<PromoPlat>(entity =>
        {
            entity.HasKey(e => new { e.IdEvenement, e.IdPlat })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("promo_plat");

            entity.HasIndex(e => e.IdEvenement, "I_FK_promo_plat_evenement");

            entity.HasIndex(e => e.IdPlat, "I_FK_promo_plat_plat");

            entity.Property(e => e.IdEvenement).HasColumnName("idEvenement");
            entity.Property(e => e.IdPlat).HasColumnName("idPlat");
            entity.Property(e => e.DateDebut)
                .HasColumnType("datetime")
                .HasColumnName("dateDebut");
            entity.Property(e => e.DateFin)
                .HasColumnType("datetime")
                .HasColumnName("dateFin");

            entity.HasOne(d => d.IdEvenementNavigation).WithMany(p => p.PromoPlats)
                .HasForeignKey(d => d.IdEvenement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("even_ibfk_1");

            entity.HasOne(d => d.IdPlatNavigation).WithMany(p => p.PromoPlats)
                .HasForeignKey(d => d.IdPlat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plat_ibfk_20");
        });

        modelBuilder.Entity<Reapprovisionnement>(entity =>
        {
            entity.HasKey(e => new { e.DateHeureReapro, e.IdPlat })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("reapprovisionnement");

            entity.HasIndex(e => e.IdPlat, "I_FK_reapprovisionnement_plat");

            entity.Property(e => e.DateHeureReapro)
                .HasColumnType("datetime")
                .HasColumnName("dateHeureReapro");
            entity.Property(e => e.IdPlat).HasColumnName("idPlat");
            entity.Property(e => e.QuantiteReapro).HasColumnName("quantiteReapro");

            entity.HasOne(d => d.IdPlatNavigation).WithMany(p => p.Reapprovisionnements)
                .HasForeignKey(d => d.IdPlat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plat_ibfk_21");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.IdReservation).HasName("PRIMARY");

            entity.ToTable("reservation");

            entity.HasIndex(e => e.IdPersonne, "I_FK_reservation_client");

            entity.HasIndex(e => e.IdTable, "I_FK_reservation_table");

            entity.Property(e => e.IdReservation).HasColumnName("idReservation");
            entity.Property(e => e.Accompte).HasColumnName("accompte");
            entity.Property(e => e.DateMoment)
                .HasColumnType("datetime")
                .HasColumnName("dateMoment");
            entity.Property(e => e.DateReservation)
                .HasColumnType("datetime")
                .HasColumnName("dateReservation");
            entity.Property(e => e.IdPersonne).HasColumnName("idPersonne");
            entity.Property(e => e.IdTable).HasColumnName("idTable");
            entity.Property(e => e.NbPersonnes).HasColumnName("nbPersonnes");
            entity.Property(e => e.Uuid)
                .HasMaxLength(256)
                .HasColumnName("uuid");

            entity.HasOne(d => d.IdPersonneNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.IdPersonne)
                .HasConstraintName("cli_ibfk_1");

            entity.HasOne(d => d.IdTableNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.IdTable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("reservation_ibfk_1");
        });

        modelBuilder.Entity<RoleCuisinier>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("role_cuisinier");

            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.LibelleRole)
                .HasMaxLength(128)
                .HasColumnName("libelleRole");
        });

        modelBuilder.Entity<Serveur>(entity =>
        {
            entity.HasKey(e => e.IdPersonne).HasName("PRIMARY");

            entity.ToTable("serveur");

            entity.Property(e => e.IdPersonne)
                .ValueGeneratedNever()
                .HasColumnName("idPersonne");
            entity.Property(e => e.Appreciations).HasColumnName("appreciations");
            entity.Property(e => e.Salaires).HasColumnName("salaires");

            entity.HasOne(d => d.IdPersonneNavigation).WithOne(p => p.Serveur)
                .HasForeignKey<Serveur>(d => d.IdPersonne)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("serveur_ibfk_1");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.IdTable).HasName("PRIMARY");

            entity.ToTable("tables");

            entity.HasIndex(e => e.IdTypeTable, "I_FK_tables_type_table");

            entity.HasIndex(e => e.IdReservation, "tables_ibfk_2");

            entity.Property(e => e.IdTable).HasColumnName("idTable");
            entity.Property(e => e.Capacite).HasColumnName("capacite");
            entity.Property(e => e.IdReservation).HasColumnName("idReservation");
            entity.Property(e => e.IdTypeTable).HasColumnName("idTypeTable");
            entity.Property(e => e.NomTable).HasMaxLength(128);

            entity.HasOne(d => d.IdReservationNavigation).WithMany(p => p.Tables)
                .HasForeignKey(d => d.IdReservation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("tables_ibfk_2");

            entity.HasOne(d => d.IdTypeTableNavigation).WithMany(p => p.Tables)
                .HasForeignKey(d => d.IdTypeTable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tables_ibfk_1");
        });

        modelBuilder.Entity<TokenApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("token_api");

            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
        });

        modelBuilder.Entity<TokenUserApi>(entity =>
        {
            entity.HasKey(e => e.Token).HasName("PRIMARY");

            entity.ToTable("token_user_api");

            entity.HasIndex(e => e.IdUser, "fk _user_token");

            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IdUser).HasColumnName("idUser");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TokenUserApis)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk _user_token");
        });

        modelBuilder.Entity<TypeEvenement>(entity =>
        {
            entity.HasKey(e => e.IdTypeEvenement).HasName("PRIMARY");

            entity.ToTable("type_evenement");

            entity.Property(e => e.IdTypeEvenement).HasColumnName("idTypeEvenement");
            entity.Property(e => e.LibelleTypeEvenement)
                .HasMaxLength(128)
                .HasColumnName("libelleTypeEvenement");
        });

        modelBuilder.Entity<TypeNotification>(entity =>
        {
            entity.HasKey(e => e.IdTypeNotification).HasName("PRIMARY");

            entity.ToTable("type_notification");

            entity.Property(e => e.IdTypeNotification).HasColumnName("idTypeNotification");
            entity.Property(e => e.LibelleTypeNotification)
                .HasMaxLength(128)
                .HasColumnName("libelleTypeNotification");
        });

        modelBuilder.Entity<TypePlat>(entity =>
        {
            entity.HasKey(e => e.IdTypePlat).HasName("PRIMARY");

            entity.ToTable("type_plat");

            entity.Property(e => e.IdTypePlat).HasColumnName("idTypePlat");
            entity.Property(e => e.LibelleTypePlat)
                .HasMaxLength(128)
                .HasColumnName("libelleTypePlat");
        });

        modelBuilder.Entity<TypeTable>(entity =>
        {
            entity.HasKey(e => e.IdTypeTable).HasName("PRIMARY");

            entity.ToTable("type_table");

            entity.Property(e => e.IdTypeTable).HasColumnName("idTypeTable");
            entity.Property(e => e.LibelleTypeTable)
                .HasMaxLength(128)
                .HasColumnName("libelleTypeTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
