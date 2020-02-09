using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HappyTravelTest.Models
{
    public partial class netstormingContext : DbContext
    {
        public netstormingContext()
        {
        }

        public netstormingContext(DbContextOptions<netstormingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookingRequestsData> BookingRequestsData { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CityZones> CityZones { get; set; }
        public virtual DbSet<ContractTypes> ContractTypes { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Distributedcache> Distributedcache { get; set; }
        public virtual DbSet<HotelDescriptions> HotelDescriptions { get; set; }
        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<MealPlans> MealPlans { get; set; }
        public virtual DbSet<Remarks> Remarks { get; set; }
        public virtual DbSet<RoomPlans> RoomPlans { get; set; }
        public virtual DbSet<StaticDataUpdateInfos> StaticDataUpdateInfos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("postgis");

            modelBuilder.Entity<BookingRequestsData>(entity =>
            {
                entity.HasIndex(e => e.ReferenceCode);

                entity.Property(e => e.BookingRequest)
                    .IsRequired()
                    .HasColumnType("jsonb");

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");

                entity.Property(e => e.LanguageCode).IsRequired();

                entity.Property(e => e.ReferenceCode).IsRequired();
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Descriptions)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.CountryCode).IsRequired();

                entity.Property(e => e.Modified).HasDefaultValueSql("'2019-12-16 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<CityZones>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasDefaultValueSql("''::text");

                entity.Property(e => e.Modified).HasDefaultValueSql("'2019-12-16 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<ContractTypes>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descriptions)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Modified).HasDefaultValueSql("'2019-12-16 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<Distributedcache>(entity =>
            {
                entity.ToTable("distributedcache");

                entity.Property(e => e.AbsoluteExpiration).HasColumnType("timestamp with time zone");

                entity.Property(e => e.ExpiresAtTime).HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<HotelDescriptions>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Descriptions)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<Hotels>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.HasIndex(e => e.CityCode)
                    .HasName("cities_btree_idx");

                entity.HasIndex(e => e.CityZoneCode);

                entity.HasIndex(e => e.CountryCode)
                    .HasName("countries_btree_idx");

                entity.HasIndex(e => e.Name)
                    .HasName("name_btree_idx");

                entity.HasIndex(e => e.Rating)
                    .HasName("rating_btree_idx");

                entity.Property(e => e.AdditionalInfo)
                    .IsRequired()
                    .HasColumnType("jsonb");

                entity.Property(e => e.CategoryCode).IsRequired();

                entity.Property(e => e.CityCode).IsRequired();

                entity.Property(e => e.CityZoneCode).IsRequired();

                entity.Property(e => e.Contacts)
                    .IsRequired()
                    .HasColumnType("jsonb");

                entity.Property(e => e.CountryCode).IsRequired();

                entity.Property(e => e.DescriptionCode).IsRequired();

                entity.Property(e => e.HotelAmenities)
                    .IsRequired()
                    .HasColumnType("jsonb");

                entity.Property(e => e.LocationDetails)
                    .IsRequired()
                    .HasColumnType("jsonb");

                entity.Property(e => e.Modified).HasDefaultValueSql("'2019-12-16 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Pictures)
                    .IsRequired()
                    .HasColumnType("jsonb");

                entity.Property(e => e.RoomAmenities)
                    .IsRequired()
                    .HasColumnType("jsonb");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasColumnType("jsonb");

                entity.Property(e => e.TextualDescriptions)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<MealPlans>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Descriptions)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<Remarks>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Descriptions)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            modelBuilder.Entity<RoomPlans>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Descriptions)
                    .IsRequired()
                    .HasColumnType("jsonb");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
