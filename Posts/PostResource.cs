using System;

namespace techlink.Posts
{
    public class PostResource
    {
        public string Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public bool Status
        {
            get;
            set;
        }

        public DateTime CreatedAt
        {
            get;
            set;
        }

        public DateTime UpdatedAt 
        {
            get;
            set;
        }

        public PostResource(string id, string name, string description, bool status, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = Status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}