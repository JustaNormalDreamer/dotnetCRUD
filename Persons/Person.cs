using System; 
using System.ComponentModel.DataAnnotations.Schema;

namespace techlink.Persons
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id {
            get;
            set;
        }

        private string name;

        public string Name {
            get => name;
            set => name = value;
        }

        public string password {
            get;
            set;
        }

        public string email {
            get; 
            set;
        }

        public DateTime createdAt {
            get;
            set;
        }

        public DateTime updatedAt {
            get;
            set;
        }

        public Person()
        {

        }

        public Person(string id, string name, string email) {
            this.id = id;
            this.name = name;
            this.email = email;
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
        }

        public Person(string id, string name, string email, string password) {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
        }
    }
}