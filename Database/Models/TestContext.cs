using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Database.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> BmaUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Test;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserIntId)
                    .HasName("PK_BMA_Users");

                entity.ToTable("bma_users");

                entity.Property(e => e.UserIntId).HasColumnName("user_int_id");

                entity.Property(e => e.Address1)
                    .HasMaxLength(61)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(61)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(61)
                    .HasColumnName("address3");

                entity.Property(e => e.AdjHireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("adj_hire_date");

                entity.Property(e => e.City)
                    .HasMaxLength(35)
                    .HasColumnName("city");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .HasColumnName("class");

                entity.Property(e => e.Country)
                    .HasMaxLength(61)
                    .HasColumnName("country");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(7)
                    .HasColumnName("country_code");

                entity.Property(e => e.DateInactivated)
                    .HasColumnType("datetime")
                    .HasColumnName("date_inactivated");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .HasColumnName("department");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .HasColumnName("email_address");

                entity.Property(e => e.Emplyid)
                    .HasMaxLength(15)
                    .HasColumnName("emplyid");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.ForcePwChange).HasColumnName("force_pw_change");

                entity.Property(e => e.HireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("hire_date");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.LastDayWorked)
                    .HasColumnType("datetime")
                    .HasColumnName("last_day_worked");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Location)
                    .HasMaxLength(15)
                    .HasColumnName("location");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("middle_name");

                entity.Property(e => e.NotificationNumber)
                    .HasMaxLength(50)
                    .HasColumnName("notificationNumber");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.PasswordExpiration)
                    .HasColumnType("datetime")
                    .HasColumnName("password_expiration");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(21)
                    .HasColumnName("phone1");

                entity.Property(e => e.Phone1ext)
                    .HasMaxLength(10)
                    .HasColumnName("phone1ext");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(21)
                    .HasColumnName("phone2");

                entity.Property(e => e.Phone2ext)
                    .HasMaxLength(10)
                    .HasColumnName("phone2ext");

                entity.Property(e => e.Phone3)
                    .HasMaxLength(21)
                    .HasColumnName("phone3");

                entity.Property(e => e.Phone3ext)
                    .HasMaxLength(10)
                    .HasColumnName("phone3ext");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("position");

                entity.Property(e => e.Reason)
                    .HasMaxLength(300)
                    .HasColumnName("reason");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .HasColumnName("ssn");

                entity.Property(e => e.State)
                    .HasMaxLength(29)
                    .HasColumnName("state");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .HasColumnName("suffix");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .HasColumnName("supervisor");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(11)
                    .HasColumnName("zip_code");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
