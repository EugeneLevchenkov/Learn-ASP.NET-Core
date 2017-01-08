using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Business.Contracts.ViewModels
{
    public class EditCommentViewModel
    {
        public int Id
        {
            get;
            set;
        }

        public int PostId
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
