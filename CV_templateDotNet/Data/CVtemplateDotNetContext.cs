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

        #region changeTracker mekanizması ile silinme durumundakki imagePath tablosunun verilerine erişir
        
        public void BeforeSaveChanges()
        {
            var deletedProject = ChangeTracker.Entries<Project>()               
                .FirstOrDefault(e => e.State == EntityState.Deleted);
            var deletedUser = ChangeTracker.Entries<User>()               
                .FirstOrDefault(e => e.State == EntityState.Deleted);
            List<ImagePath> deletedImages = new List<ImagePath>();
             if(deletedProject != null)
            {
                var deletedProjectId = deletedProject.Entity.Id;
                deletedImages=ImagePaths.Where(id=>id.PojectId== deletedProjectId).ToList();
            }
            else if (deletedUser != null)
            {
                var deletedUserId = deletedUser.Entity.Id;
                deletedImages = ImagePaths.Where(id => id.UserId == deletedUserId).ToList();
            }   

             foreach (var imagePath in deletedImages) 
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/{imagePath.CvImagePath}");
                File.Delete(path);
            }
                // Deleted durumundaki varlık hakkında bilgileri alabilirsiniz
                //int id = deletedEntity.Id;
                // Diğer özelliklere erişim sağlayabilirsiniz
                //File.Delete($"~/{deletedEntity.CvImagePath}");
                //Console.WriteLine($"~/{deletedEntity.}");
            
        }
        #endregion
        public override int SaveChanges()
        {
            BeforeSaveChanges();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            BeforeSaveChanges();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

    }

}
