namespace SocialNetwork.Data.Contracts.Entities
{
    public class Post : BaseEntity
    {
        public string Content
        {
            get;
            set;
        }

        public int AuthorId
        {
            get;
            set;
        }

        public virtual UserProfile Author
        {
            get;
            set;
        }
    }
}
