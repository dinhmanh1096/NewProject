using Microsoft.AspNetCore.Identity;

namespace NewProject.Data
{
    public class ApplicationUser:IdentityUser<int>
    {
        public int CustomTag { get; set; }
    }
}
