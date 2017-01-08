using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.ViewModels.Security
{
    public class RegisterViewModel
    {
        [Required]
        public string Email
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordConfirm
        {
            get;
            set;
        }
    }
}
