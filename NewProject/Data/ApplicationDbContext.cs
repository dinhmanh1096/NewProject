using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace NewProject.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }
        #region DbSet
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        #endregion
        public class ApplicationUser : IdentityUser
        {
            public virtual ICollection<Workout> Claims { get; set; }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            builder.Entity<Workout>(w =>
            {
                w.ToTable("Workout");
                w.HasKey(e => e.WorkoutID);

                w.HasOne(e => e.sport)
               .WithMany(e => e.Workouts)
               .HasForeignKey(e => e.SportID)
               .HasConstraintName("FK_Sport_Workout");    
                               
            });

            builder.Entity<Sport>(e =>
            {
                e.ToTable("Sport");
                e.HasKey(sp => sp.SportID);
            });
            builder.Entity<ApplicationUser>(b =>
            {
                b.HasMany(e => e.Claims)
                    .WithOne()
                    .HasForeignKey(uc => uc.Id)
                    .IsRequired();
            });
        }
        private static void SeedRoles(ModelBuilder model)
        {
            model.Entity<IdentityRole>().HasData
            (
                new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Name="User",ConcurrencyStamp="2",NormalizedName="User"}
            );
            
        }
    }
}
