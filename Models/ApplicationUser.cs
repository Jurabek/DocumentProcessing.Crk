using Microsoft.AspNetCore.Identity;

namespace DocumentProcessing.Srk.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public string LastName { get; set; }
    }
}