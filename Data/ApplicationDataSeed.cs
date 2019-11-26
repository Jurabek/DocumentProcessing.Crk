using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentProcessing.Srk.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace DocumentProcessing.Srk.Data
{
    public class ApplicationDataSeed
    {
        public async Task Seed(
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager,
            ILogger<ApplicationDataSeed> logger,
            IConfiguration configuration,
            ApplicationDbContext context)
        {
        }
    }
}