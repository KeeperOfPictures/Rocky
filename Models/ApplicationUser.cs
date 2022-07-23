using Microsoft.AspNetCore.Identity;

namespace Rocky_Tile.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
