using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CV_templateDotNet.Models;

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
                .HasForeignKey(c => c.PojectId);

        }
    }

}
