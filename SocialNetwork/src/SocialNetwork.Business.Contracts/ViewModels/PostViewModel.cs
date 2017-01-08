using System.Collections.Generic;

namespace SocialNetwork.Business.Contracts.ViewModels
{
    public class PostViewModel
    {
        public int Id
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public IEnumerable<CommentViewModel> Comments
        {
            get;
            set;
        }
    }
}
