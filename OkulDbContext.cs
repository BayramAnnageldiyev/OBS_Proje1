using Microsoft.EntityFrameworkCore;

namespace OBS_Proje
{
    public class OkulDbContext : DbContext
    {
        public DbSet<Ogrenciler> Ogrenciler { get; set; }
        public DbSet<tblDersler> Dersler { get; set; }
        public DbSet<tblSiniflar> Siniflar { get; set; }
        public DbSet<tblOgrenciDers> OgrenciDersler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=OkulProjeDB;Integrated Security=True;TrustServerCertificate=true",
                options => options.CommandTimeout(120));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Ogrenciler>()
                .HasIndex(o => o.Numara)
                .IsUnique();

           
            modelBuilder.Entity<Ogrenciler>()
                .HasOne(o => o.Sinif)
                .WithMany(s => s.Ogrenciler)
                .HasForeignKey(o => o.SinifId)
                .OnDelete(DeleteBehavior.Restrict); 

            
            modelBuilder.Entity<tblDersler>()
                .HasIndex(d => d.DersKodu)
                .IsUnique();

      
            modelBuilder.Entity<tblOgrenciDers>()
                .HasKey(od => new { od.OgrenciId, od.DersId });

          
            modelBuilder.Entity<tblOgrenciDers>()
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.OgrenciDersler)
                .HasForeignKey(od => od.OgrenciId)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<tblOgrenciDers>()
                .HasOne(od => od.Ders)
                .WithMany(d => d.OgrenciDersler)
                .HasForeignKey(od => od.DersId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
