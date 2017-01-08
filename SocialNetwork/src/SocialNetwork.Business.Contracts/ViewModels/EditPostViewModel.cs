using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Business.Contracts.ViewModels
{
    public class EditPostViewModel
    {
        public int Id
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Content
        {
            get;
            set;
        }
    }
}
