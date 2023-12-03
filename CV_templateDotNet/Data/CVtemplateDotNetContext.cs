using Microsoft.EntityFrameworkCore;
using CV_templateDotNet.Models;
using System.IO;
namespace CV_templateDotNet.Data
{
    public class CVtemplateDotNetContext : DbContext
    {
        public CVtemplateDotNetContext (DbContextOptions<CVtemplateDotNetContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
        public DbSet<Education> Educations { get; set; } = default!;
        public DbSet<ImagePath> ImagePaths { get; set; } = default!;
        public DbSet<NetworkReferances> NetworkReferances { get; set; } = default!;
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImagePath>()
                .HasOne(c => c.Project)
                .WithMany(d => d.Images)
            .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ImagePath>()
                .HasOne(c => c.User)
                .WithMany(d => d.ProfilImage)
            .OnDelete(DeleteBehavior.Cascade);

        }
        
    }

}
