using Microsoft.AspNetCore.Identity;

namespace QuizAndTestSite.Models
{
    public class AspNetUserModel : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
