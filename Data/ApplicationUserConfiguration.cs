using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OptionsMeter.Models;

namespace OptionsMeter.Data
{
    public static class ApplicationUserConfiguration
    {
        public static void ConfigureApplicationUser(this ModelBuilder builder)
        {
            var entity = builder.Entity<ApplicationUser>();
            entity.ToTable("users");

            entity.Property(e => e.Id)
                  .HasColumnName("id")
                  .HasMaxLength(256);

            entity.Property(e => e.AccessFailedCount)
                  .HasColumnName("access_failed_count");

            entity.Property(e => e.ConcurrencyStamp)
                  .HasColumnName("concurrency_stamp")
                  .HasMaxLength(64);

            entity.Property(e => e.Email)
                  .HasColumnName("email")
                  .HasMaxLength(512);

            entity.Property(e => e.EmailConfirmed)
                  .HasColumnName("email_confirmed")
                  .HasMaxLength(512);

            entity.Property(e => e.LockoutEnabled)
                  .HasColumnName("lockout_enabled");

            entity.Property(e => e.LockoutEnd)
                  .HasColumnName("lockout_end");

            entity.Property(e => e.NormalizedEmail)
                  .HasColumnName("normalized_email")
                  .HasMaxLength(256);

            entity.Property(e => e.NormalizedUserName)
                  .HasColumnName("normalized_username")
                  .HasMaxLength(256);

            entity.Property(e => e.PasswordHash)
                  .HasColumnName("password_hash");

            entity.Property(e => e.PhoneNumber)
                  .HasColumnName("phone_number")
                  .HasMaxLength(128);

            entity.Property(e => e.PhoneNumberConfirmed)
                  .HasColumnName("phone_number_confirmed")
                  .HasMaxLength(128);

            entity.Property(e => e.SecurityStamp)
                  .HasColumnName("security_stamp")
                  .HasMaxLength(64);

            entity.Property(e => e.TwoFactorEnabled)
                  .HasColumnName("two_factor_enabled");

            entity.Property(e => e.UserName)
                  .HasColumnName("username")
                  .HasMaxLength(256);
        }
    }
}
