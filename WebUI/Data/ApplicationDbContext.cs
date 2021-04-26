using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using WebUI.Data.Seeds;
using WebUI.Models;
using WebUI.Models.Common;
using WebUI.Models.Identity;

namespace WebUI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<CoateRecord> CoateRecords { get; set; }

        public DbSet<Avatar> Avatars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            foreach (var foreignKey in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
            builder.AddCoateSeedData();
            builder.AddApplicationUserSeedData();
            builder.AddHostelSeedData();
        }

        public override Task<int> SaveChangesAsync(CancellationToken token = new CancellationToken())
        {
            int userId = 0;
            var httpContextAccessor = this.GetService<IHttpContextAccessor>();
            string userIdVal = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!string.IsNullOrEmpty(userIdVal))
                userId = Convert.ToInt32(userIdVal);

            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = userId;
                        entry.Entity.Created = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = userId;
                        entry.Entity.LastModified = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(token);
        }
    }
}