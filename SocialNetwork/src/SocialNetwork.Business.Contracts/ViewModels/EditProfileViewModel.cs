using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Business.Contracts.ViewModels
{
    public class EditProfileViewModel
    {
        [Required]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        public string LastName
        {
            get;
            set;
        }
    }
}
