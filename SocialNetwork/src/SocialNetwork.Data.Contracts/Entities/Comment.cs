namespace SocialNetwork.Data.Contracts.Entities
{
    public class Comment : BaseEntity
    {
        public int PostId
        {
            get;
            set;
        }

        public virtual Post Post
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

        public string Content
        {
            get;
            set;
        }
    }
}
