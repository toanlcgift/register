using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Register.Models
{
    public partial class paysysContext : DbContext
    {
        public paysysContext()
        {
        }

        public paysysContext(DbContextOptions<paysysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;user=root;password=1234;database=paysys;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account", "paysys");

                entity.HasIndex(e => e.Username)
                    .HasName("u")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Bklactive)
                    .HasColumnName("bklactive")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bklactivenew)
                    .HasColumnName("bklactivenew")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Changepwdret)
                    .HasColumnName("changepwdret")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasColumnType("int(9)")
                    .HasDefaultValueSql("123456780");

                entity.Property(e => e.Coin)
                    .HasColumnName("coin")
                    .HasColumnType("int(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("dateCreate")
                    .HasColumnType("int(20)");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("sgame@sgamevn.com");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("LastLoginIP")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockPassword)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockedCoin)
                    .HasColumnName("lockedCoin")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LockedTime).HasColumnName("lockedTime");

                entity.Property(e => e.NExtpoin1)
                    .HasColumnName("nExtpoin1")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NExtpoin2)
                    .HasColumnName("nExtpoin2")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NExtpoin4)
                    .HasColumnName("nExtpoin4")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NExtpoin5)
                    .HasColumnName("nExtpoin5")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NExtpoin6)
                    .HasColumnName("nExtpoin6")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NExtpoin7)
                    .HasColumnName("nExtpoin7")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NLockTimeCard)
                    .HasColumnName("nLockTimeCard")
                    .HasColumnType("int(15)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NTimeActiveBkl)
                    .HasColumnName("nTimeActiveBKL")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Newlocked)
                    .HasColumnName("newlocked")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PasspodMode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("a");

                entity.Property(e => e.Rowpass)
                    .HasColumnName("rowpass")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("a");

                entity.Property(e => e.Scredit)
                    .HasColumnName("scredit")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Secpassword)
                    .IsRequired()
                    .HasColumnName("secpassword")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("e8c54b11d35825097bdbfccea0d16079");

                entity.Property(e => e.Testcoin)
                    .HasColumnName("testcoin")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("9999999");

                entity.Property(e => e.Trytocard)
                    .HasColumnName("trytocard")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Trytohack)
                    .HasColumnName("trytohack")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("test03");
            });
        }
    }
}
