using DocumentProcessing.Crk.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace DocumentProcessing.Crk.Data
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
        }
    }
}