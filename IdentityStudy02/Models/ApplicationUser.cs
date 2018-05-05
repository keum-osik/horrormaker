using Microsoft.AspNetCore.Identity;

namespace IdentityStudy02.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<int>
    {
        public string 이름_변경 { get; set; }
        public string 나이 { get; set; }

    }
}
