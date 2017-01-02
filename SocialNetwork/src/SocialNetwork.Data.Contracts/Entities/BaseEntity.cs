using System;

namespace SocialNetwork.Data.Contracts.Entities
{
    public class BaseEntity
    {
        public int Id
        {
            get;
            set;
        }

        public DateTime Created
        {
            get;
            set;
        }

        public DateTime Updated
        {
            get;
            set;
        }

        public long Version
        {
            get;
            set;
        }
    }
}
