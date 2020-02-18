using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace TrackingAPI.Models
{
    public partial class APITrackingContext : DbContext
    {
        public APITrackingContext()
        {
        }

        public APITrackingContext(DbContextOptions<APITrackingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ShipmentHistory> ShipmentHistory { get; set; }
        public virtual DbSet<ShipmentHistoryItem> ShipmentHistoryItem { get; set; }
        public virtual DbSet<ShipmentHistoryJs> ShipmentHistoryJs { get; set; }
        public virtual DbSet<ShipmentHistoryItemJs> ShipmentHistoryItemJs { get; set; }

        public IConfiguration Configuration { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration["Data:APIConnection:ConnectionString"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShipmentHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HisClientFullName)
                    .HasColumnName("HIS_ClientFullName")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisConsignee)
                    .HasColumnName("HIS_Consignee")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisConsolNumber)
                    .HasColumnName("HIS_ConsolNumber")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisDeliverAddress)
                    .HasColumnName("HIS_DeliverAddress")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisDestination)
                    .HasColumnName("HIS_Destination")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisEta)
                    .HasColumnName("HIS_ETA")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisEtd)
                    .HasColumnName("HIS_ETD")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisInsertDate)
                    .HasColumnName("HIS_InsertDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HisLocalClient)
                    .HasColumnName("HIS_LocalClient")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisNotifyParty)
                    .HasColumnName("HIS_NotifyParty")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisOrigin)
                    .HasColumnName("HIS_Origin")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisPk)
                    .HasColumnName("HIS_PK")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HisShipmentNumber)
                    .IsRequired()
                    .HasColumnName("HIS_ShipmentNumber")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisShipper)
                    .HasColumnName("HIS_Shipper")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisStatus)
                    .HasColumnName("HIS_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HisTransportMode)
                    .HasColumnName("HIS_TransportMode")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisUpdateDate)
                    .HasColumnName("HIS_UpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HisVolume)
                    .HasColumnName("HIS_Volume")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisVoyage)
                    .HasColumnName("HIS_Voyage")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisWeight)
                    .HasColumnName("HIS_Weight")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShipmentHistoryItem>(entity =>
            {
                entity.HasKey(e => e.HiiId);

                entity.Property(e => e.HiiId).HasColumnName("HII_ID");

                entity.Property(e => e.HiiEventCode)
                    .HasColumnName("HII_EventCode")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiEventDate)
                    .HasColumnName("HII_EventDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HiiHis).HasColumnName("HII_HIS");

                entity.Property(e => e.HiiLocation)
                    .HasColumnName("HII_Location")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiObservation)
                    .HasColumnName("HII_Observation")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiStatusDetail)
                    .HasColumnName("HII_StatusDetail")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShipmentHistoryJs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HisClientFullName)
                    .HasColumnName("HIS_ClientFullName")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisConsignee)
                    .HasColumnName("HIS_Consignee")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisConsolNumber)
                    .HasColumnName("HIS_ConsolNumber")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisDeliverAddress)
                    .HasColumnName("HIS_DeliverAddress")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisDestination)
                    .HasColumnName("HIS_Destination")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisEta)
                    .HasColumnName("HIS_ETA")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisEtd)
                    .HasColumnName("HIS_ETD")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisInsertDate)
                    .HasColumnName("HIS_InsertDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HisLocalClient)
                    .HasColumnName("HIS_LocalClient")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisNotifyParty)
                    .HasColumnName("HIS_NotifyParty")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisOrigin)
                    .HasColumnName("HIS_Origin")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisPk)
                    .HasColumnName("HIS_PK")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HisShipmentNumber)
                    .IsRequired()
                    .HasColumnName("HIS_ShipmentNumber")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisShipper)
                    .HasColumnName("HIS_Shipper")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisStatus)
                    .HasColumnName("HIS_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HisTransportMode)
                    .HasColumnName("HIS_TransportMode")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisUpdateDate)
                    .HasColumnName("HIS_UpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HisVolume)
                    .HasColumnName("HIS_Volume")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisVoyage)
                    .HasColumnName("HIS_Voyage")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HisWeight)
                    .HasColumnName("HIS_Weight")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
                
                entity.Property(e => e.HiiId).HasColumnName("HII_ID");

                entity.Property(e => e.HiiEventCode)
                    .HasColumnName("HII_EventCode")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiEventDate)
                    .HasColumnName("HII_EventDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HiiHis).HasColumnName("HII_HIS");

                entity.Property(e => e.HiiLocation)
                    .HasColumnName("HII_Location")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiObservation)
                    .HasColumnName("HII_Observation")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiStatusDetail)
                    .HasColumnName("HII_StatusDetail")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShipmentHistoryItemJs>(entity =>
            {
                entity.HasKey(e => e.HiiId);

                entity.Property(e => e.HiiId).HasColumnName("HII_ID");

                entity.Property(e => e.HiiEventCode)
                    .HasColumnName("HII_EventCode")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiEventDate)
                    .HasColumnName("HII_EventDate")
                    .HasMaxLength(1000);

                entity.Property(e => e.HiiHis).HasColumnName("HII_HIS");

                entity.Property(e => e.HiiLocation)
                    .HasColumnName("HII_Location")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiObservation)
                    .HasColumnName("HII_Observation")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HiiStatusDetail)
                    .HasColumnName("HII_StatusDetail")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
