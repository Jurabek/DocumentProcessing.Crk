using DocumentProcessing.Srk.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace DocumentProcessing.Srk.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration _configuration;

        // static ApplicationDbContext()
        // {
        //     NpgsqlConnection.GlobalTypeMapper.MapEnum<AppointmentCharacters>();
        // }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.ForNpgsqlHasEnum<AppointmentCharacters>();

            modelBuilder.Entity<Order>()
                .HasOne(o => o.ScannedFile)
                .WithOne()
                .HasForeignKey<Order>(x => x.ScannedFileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentSrk>()
                .HasOne(x => x.FirstOrder)
                .WithOne()
                .HasForeignKey<DocumentSrk>(x => x.FirstOrderId)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<DocumentSrk>()
                .HasOne(x => x.SecondOrder)
                .WithOne()
                .HasForeignKey<DocumentSrk>(x => x.SecondOrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}