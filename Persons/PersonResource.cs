using System;

namespace techlink.Persons
{
    public class PersonResource
    {
        public string id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string email
        {
            get;
            set;
        }

        public DateTime createdAt
        {
            get;
            set;
        }

        public DateTime updatedAt 
        {
            get;
            set;
        }

        public PersonResource(string id, string name, string email, DateTime createdAt, DateTime updatedAt)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
    }
}