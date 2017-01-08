using System.Collections.Generic;

namespace SocialNetwork.Business.Contracts.ViewModels
{
    public class ProfileViewModel
    {
        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public IEnumerable<PostViewModel> Posts
        {
            get;
            set;
        }
    }
}
