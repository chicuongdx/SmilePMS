using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmilePMS.Entities
{
    public partial class SMILEPMSDBQueryContext : DbContext
    {
        public SMILEPMSDBQueryContext()
        {
        }

        public SMILEPMSDBQueryContext(DbContextOptions<SMILEPMSDBQueryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ReservationDetail> ReservationDetails { get; set; } = null!;
        public virtual DbSet<ReservationGuest> ReservationGuests { get; set; } = null!;
        public virtual DbSet<RoomInfo> RoomInfos { get; set; } = null!;
        public virtual DbSet<RoomType> RoomTypes { get; set; } = null!;
        public virtual DbSet<TransactionItem> TransactionItems { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SMILEPMSDBQuery;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservationDetail>(entity =>
            {
                entity.HasKey(e => e.FolioNum)
                    .HasName("PK__Reservat__E327F2449417C811");

                entity.ToTable("ReservationDetail");

                entity.Property(e => e.FolioNum)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ArivalDate).HasColumnType("date");

                entity.Property(e => e.BookerName).HasMaxLength(100);

                entity.Property(e => e.BreakfastCode)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.CancelNum)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ConfirmNum)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DepartureDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.IncludeBf).HasColumnName("IncludeBF");

                entity.Property(e => e.NumEbd).HasColumnName("NumEBD");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.RateGuestCard).HasColumnType("money");

                entity.Property(e => e.ReservationTime).HasColumnType("datetime");

                entity.Property(e => e.RoomCode)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.RoomTypeCode)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Tacode)
                    .HasMaxLength(10)
                    .HasColumnName("TACode")
                    .IsFixedLength();

                entity.Property(e => e.Taname)
                    .HasMaxLength(100)
                    .HasColumnName("TAName");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.TotalBalance).HasColumnType("money");

                entity.Property(e => e.TotalPay).HasColumnType("money");

                entity.HasOne(d => d.RoomTypeCodeNavigation)
                    .WithMany(p => p.ReservationDetails)
                    .HasForeignKey(d => d.RoomTypeCode)
                    .HasConstraintName("FK__Reservati__RoomT__25518C17");
            });

            modelBuilder.Entity<ReservationGuest>(entity =>
            {
                entity.HasKey(e => e.IdAddition)
                    .HasName("PK__Reservat__A527AEFC50D9B9B1");

                entity.ToTable("ReservationGuest");

                entity.Property(e => e.IdAddition)
                    .HasMaxLength(10)
                    .HasColumnName("idAddition")
                    .IsFixedLength();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CardNumber).HasMaxLength(20);

                entity.Property(e => e.Cccd)
                    .HasMaxLength(20)
                    .HasColumnName("CCCD");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(20)
                    .HasColumnName("CMND");

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ExpDateVisa).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FolioNum)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Gplx)
                    .HasMaxLength(20)
                    .HasColumnName("GPLX");

                entity.Property(e => e.GuestSn)
                    .HasMaxLength(10)
                    .HasColumnName("GuestSN")
                    .IsFixedLength();

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.NationalCode).HasMaxLength(20);

                entity.Property(e => e.Passport).HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(20);

                entity.Property(e => e.Visa).HasMaxLength(20);

                entity.HasOne(d => d.FolioNumNavigation)
                    .WithMany(p => p.ReservationGuests)
                    .HasForeignKey(d => d.FolioNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__Folio__282DF8C2");
            });

            modelBuilder.Entity<RoomInfo>(entity =>
            {
                entity.HasKey(e => e.RoomCode)
                    .HasName("PK__RoomInfo__4F9D52303DD1E6E4");

                entity.ToTable("RoomInfo");

                entity.Property(e => e.RoomCode).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.RoomTypeCode)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.HasOne(d => d.RoomTypeCodeNavigation)
                    .WithMany(p => p.RoomInfos)
                    .HasForeignKey(d => d.RoomTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RoomInfo__RoomTy__22751F6C");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.HasKey(e => e.RoomTypeCode)
                    .HasName("PK__RoomType__F06AB9520108AFEA");

                entity.ToTable("RoomType");

                entity.Property(e => e.RoomTypeCode)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<TransactionItem>(entity =>
            {
                entity.HasKey(e => e.Icode)
                    .HasName("PK__Transact__A8798331AE05A547");

                entity.ToTable("TransactionItem");

                entity.Property(e => e.Icode)
                    .HasMaxLength(10)
                    .HasColumnName("ICode")
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Qty).HasColumnName("QTY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
