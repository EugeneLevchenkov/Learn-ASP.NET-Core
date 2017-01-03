using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Business.Contracts.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email
        {
            get;
            set;
        }

        [Required]
        public string Password
        {
            get;
            set;
        }
    }
}
