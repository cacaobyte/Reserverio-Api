using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ReserverioCore.ML.Reserverio;

namespace Reserverio.DAL.Commerce.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CouponClassification> CouponClassifications { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<PublicUser> PublicUsers { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<ReservationDetail> ReservationDetails { get; set; }

    public virtual DbSet<ReservationLog> ReservationLogs { get; set; }

    public virtual DbSet<ReservationService> ReservationServices { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleOperation> RoleOperations { get; set; }

    public virtual DbSet<ServiceImage> ServiceImages { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<TenantBilling> TenantBillings { get; set; }

    public virtual DbSet<TenantBranding> TenantBrandings { get; set; }

    public virtual DbSet<TenantClassification> TenantClassifications { get; set; }

    public virtual DbSet<TenantClassificationMap> TenantClassificationMaps { get; set; }

    public virtual DbSet<TenantCoupon> TenantCoupons { get; set; }

    public virtual DbSet<TenantCouponService> TenantCouponServices { get; set; }

    public virtual DbSet<TenantCouponUsageDetail> TenantCouponUsageDetails { get; set; }

    public virtual DbSet<TenantCouponUsageLog> TenantCouponUsageLogs { get; set; }

    public virtual DbSet<TenantFeature> TenantFeatures { get; set; }

    public virtual DbSet<TenantLocaleSetting> TenantLocaleSettings { get; set; }

    public virtual DbSet<TenantNotification> TenantNotifications { get; set; }

    public virtual DbSet<TenantSchedule> TenantSchedules { get; set; }

    public virtual DbSet<TenantSetting> TenantSettings { get; set; }

    public virtual DbSet<TenantUserBlockList> TenantUserBlockLists { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserFavorite> UserFavorites { get; set; }

    public virtual DbSet<UserLoginLog> UserLoginLogs { get; set; }

    public virtual DbSet<UserRating> UserRatings { get; set; }

    public virtual DbSet<UserRatingPhoto> UserRatingPhotos { get; set; }

    public virtual DbSet<UsersRole> UsersRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=ep-noisy-sea-ae3p0izv-pooler.c-2.us-east-2.aws.neon.tech;Port=5432;Username=neondb_owner;Password=npg_EOwKcdLexF68;Database=neondb;SSL Mode=Require;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Countries_pkey");

            entity.Property(e => e.Continent).HasMaxLength(50);
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.CurrencyCode).HasMaxLength(10);
            entity.Property(e => e.CurrencySymbol).HasMaxLength(10);
            entity.Property(e => e.FlagUrl).HasMaxLength(255);
            entity.Property(e => e.IsoCode).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PhoneCode).HasMaxLength(10);
            entity.Property(e => e.Timezone).HasMaxLength(255);
        });

        modelBuilder.Entity<CouponClassification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CouponClassifications_pkey");

            entity.Property(e => e.ColorCode).HasMaxLength(255);
            entity.Property(e => e.IconUrl).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Slug).HasMaxLength(255);
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Module_pkey");

            entity.ToTable("Module");

            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Icon).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Route).HasMaxLength(255);
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Operations_pkey");

            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdModulo).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Organizations_pkey");

            entity.Property(e => e.CountryId).ValueGeneratedOnAdd();
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.LegalName).HasMaxLength(255);
            entity.Property(e => e.LogoUrl).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(25);
            entity.Property(e => e.Website).HasMaxLength(255);
        });

        modelBuilder.Entity<PublicUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PublicUsers_pkey");

            entity.Property(e => e.AvatarUrl).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.PreferredLanguage).HasMaxLength(10);
            entity.Property(e => e.PreferredTimezone).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Reservations_pkey");

            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PublicUserId).ValueGeneratedOnAdd();
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasMaxLength(255);
        });

        modelBuilder.Entity<ReservationDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ReservationDetails_pkey");

            entity.Property(e => e.ReservationId).ValueGeneratedOnAdd();
            entity.Property(e => e.ServiceId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReservationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ReservationLogs_pkey");

            entity.Property(e => e.Action).HasMaxLength(255);
            entity.Property(e => e.PerformedBy).HasMaxLength(255);
            entity.Property(e => e.ReservationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ReservationId ");
        });

        modelBuilder.Entity<ReservationService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ReservationServices_pkey");

            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Duration).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Price).HasMaxLength(255);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Role_pkey");

            entity.ToTable("Role");

            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<RoleOperation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Role_Operations_pkey");

            entity.ToTable("Role_Operations");

            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.IdOperacion).ValueGeneratedOnAdd();
            entity.Property(e => e.IdRol).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ServiceImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ServiceImages_pkey");

            entity.Property(e => e.AltText).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.ServiceId).ValueGeneratedOnAdd();
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tenant_pkey");

            entity.ToTable("Tenant");

            entity.Property(e => e.AddressLine).HasMaxLength(255);
            entity.Property(e => e.BrandColor).HasMaxLength(20);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.ContactEmail).HasMaxLength(255);
            entity.Property(e => e.ContactPhone).HasMaxLength(25);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.CountryId).ValueGeneratedOnAdd();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CustomUrl).HasMaxLength(255);
            entity.Property(e => e.IdSetting).ValueGeneratedOnAdd();
            entity.Property(e => e.Industry).HasMaxLength(255);
            entity.Property(e => e.Latitude).HasPrecision(9, 6);
            entity.Property(e => e.Longitude).HasPrecision(9, 6);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentTenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.Plan).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.StateOrRegion).HasMaxLength(255);
            entity.Property(e => e.Timezone).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
        });

        modelBuilder.Entity<TenantBilling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tenant_Billing_pkey");

            entity.ToTable("Tenant_Billing");

            entity.Property(e => e.BillingPlan).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.PaymentStatus).HasMaxLength(255);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<TenantBranding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tenant_Branding_pkey");

            entity.ToTable("Tenant_Branding");

            entity.Property(e => e.CustomCss).HasColumnName("CustomCSS");
            entity.Property(e => e.Font).HasMaxLength(100);
            entity.Property(e => e.LogoUrl).HasMaxLength(255);
            entity.Property(e => e.PrimaryColor).HasMaxLength(20);
            entity.Property(e => e.SecondaryColor).HasMaxLength(20);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TenantClassification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TenantClassifications_pkey");

            entity.Property(e => e.ColorCode).HasMaxLength(255);
            entity.Property(e => e.IconUrl).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Slug).HasMaxLength(255);
        });

        modelBuilder.Entity<TenantClassificationMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TenantClassificationMap_pkey");

            entity.ToTable("TenantClassificationMap");

            entity.Property(e => e.ClassId).ValueGeneratedOnAdd();
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TenantCoupon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TenantCoupons_pkey");

            entity.Property(e => e.ClassificationId).ValueGeneratedOnAdd();
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.DiscountType).HasMaxLength(255);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TenantCouponService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TenantCouponServices_pkey");

            entity.Property(e => e.CouponId).ValueGeneratedOnAdd();
            entity.Property(e => e.ServiceId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TenantCouponUsageDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TenantCouponUsageDetails_pkey");

            entity.Property(e => e.ServiceId).ValueGeneratedOnAdd();
            entity.Property(e => e.UsageLogId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TenantCouponUsageLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TenantCouponUsageLogs_pkey");

            entity.Property(e => e.CouponId).ValueGeneratedOnAdd();
            entity.Property(e => e.PublicUserId).ValueGeneratedOnAdd();
            entity.Property(e => e.ReservationId).ValueGeneratedOnAdd();
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TenantFeature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tenant_Features_pkey");

            entity.ToTable("Tenant_Features");

            entity.Property(e => e.FeatureCode).HasMaxLength(255);
            entity.Property(e => e.TenantId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TenantId ");
        });

        modelBuilder.Entity<TenantLocaleSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tenant_LocaleSettings_pkey");

            entity.ToTable("Tenant_LocaleSettings");

            entity.Property(e => e.CurrencyCode).HasMaxLength(20);
            entity.Property(e => e.DateFormat).HasMaxLength(255);
            entity.Property(e => e.LanguageCode).HasMaxLength(20);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.TimeFormat).HasMaxLength(50);
            entity.Property(e => e.Timezone).HasMaxLength(100);
        });

        modelBuilder.Entity<TenantNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tenant_Notifications_pkey");

            entity.ToTable("Tenant_Notifications");

            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.NotificationType).HasMaxLength(255);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.Transmitter)
                .HasMaxLength(255)
                .HasColumnName("transmitter");
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<TenantSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tenant_Schedule_pkey");

            entity.ToTable("Tenant_Schedule");

            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.DayName).HasMaxLength(255);
            entity.Property(e => e.IdSetting).ValueGeneratedOnAdd();
            entity.Property(e => e.ScheduleType).HasMaxLength(255);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<TenantSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Tenant_Settings_pkey");

            entity.ToTable("Tenant_Settings", tb => tb.HasComment("Tabla de configuraciones del Tenant del negocio para poder aplicar asi las reglas del negocio del sistema y asi mismo a los usuarios los cuales han interactuado con este tenant"));

            entity.Property(e => e.AllowDoubleBooking).HasComment("Sirve para validar si se permite una reservación doble por día");
            entity.Property(e => e.AllowMultipleServicesPerBooking).HasComment("Si una reserva puede tener más de un servicio seleccionado");
            entity.Property(e => e.AutoApproveReservations).HasComment("Si las reservas deben aprobarse manualmente o entran directas");
            entity.Property(e => e.BlockBlacklistedEmails).HasComment("Bloquea correos que han sido baneados previamente");
            entity.Property(e => e.BookingSlotDurationMinutes).HasComment("Duración estándar del bloque (ej: 30 minutos, 60, etc.)");
            entity.Property(e => e.BookingWindowDays).HasDefaultValue(7);
            entity.Property(e => e.CancelationTimeLimitHours).HasComment("Cuántas horas antes se puede cancelar una reserva");
            entity.Property(e => e.CustomTheme)
                .HasMaxLength(255)
                .HasColumnName("CustomTheme ");
            entity.Property(e => e.EnableReschedule).HasComment("Permitir reprogramar reservas sin cancelar");
            entity.Property(e => e.EnableSmsnotifications)
                .HasComment("Si se activan mensajes SMS (por plan Premium, por ejemplo)")
                .HasColumnName("EnableSMSNotifications");
            entity.Property(e => e.MaxDailyBookingsPerUser).HasComment("Limita cuántas reservas puede hacer un usuario por día");
            entity.Property(e => e.MinHoursBeforeBooking).HasComment("Define cuántas horas antes debe reservar (ej: 2h de anticipación mínima)");
            entity.Property(e => e.ShowAvailableSlotsOnly).HasComment("Solo muestra horarios disponibles (sin mostrar todos los bloques)");
            entity.Property(e => e.TenantSettings).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TenantUserBlockList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TenantUserBlockList_pkey");

            entity.ToTable("TenantUserBlockList");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.PublicUserId).ValueGeneratedOnAdd();
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Users_pkey");

            entity.HasIndex(e => e.Email, "Users_Email_key").IsUnique();

            entity.HasIndex(e => e.UserName, "Users_UserName_key").IsUnique();

            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.Observation).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.PhotoUrl).HasMaxLength(255);
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<UserFavorite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("UserFavorites_pkey");

            entity.Property(e => e.AliasName).HasMaxLength(255);
            entity.Property(e => e.PublicUserId)
                .ValueGeneratedOnAdd()
                .HasColumnName(" PublicUserId");
            entity.Property(e => e.Qualification).HasColumnName("qualification");
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UserLoginLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("UserLoginLogs_pkey");

            entity.Property(e => e.IpAddress).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.LoginMethod).HasMaxLength(255);
            entity.Property(e => e.PublicUserId).ValueGeneratedOnAdd();
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserAgent).HasComment("Información del navegador o dispositivo");
            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UserRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("UserRatings_pkey");

            entity.Property(e => e.PublicUserId).ValueGeneratedOnAdd();
            entity.Property(e => e.RatingType)
                .HasMaxLength(255)
                .HasComment("Tipo de calificación: \"general\", \"servicio\", \"instalaciones\", \"tiempo\", etc. Sirve si quieres tener múltiples criterios.");
            entity.Property(e => e.TenantId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UserRatingPhoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("UserRatingPhotos_pkey");

            entity.Property(e => e.AltText).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.UploadedBy).HasMaxLength(255);
            entity.Property(e => e.UserRatingId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UsersRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Users_Role_pkey");

            entity.ToTable("Users_Role");

            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.IdRol).ValueGeneratedOnAdd();
            entity.Property(e => e.IdUsers).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
