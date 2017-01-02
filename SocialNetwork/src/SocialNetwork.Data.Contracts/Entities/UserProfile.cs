using System.Collections.Generic;

namespace SocialNetwork.Data.Contracts.Entities
{
    public class UserProfile : BaseEntity
    {
        public string UserId
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

        public virtual IEnumerable<Post> Posts
        {
            get;
            set;
        }
    }
}
