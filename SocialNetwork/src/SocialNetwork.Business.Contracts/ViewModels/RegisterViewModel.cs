using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Business.Contracts.ViewModels
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
