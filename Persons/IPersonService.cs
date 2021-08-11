
using System.Collections.Generic;
using System.Threading.Tasks;

namespace techlink.Persons
{
    public interface IPersonService
    {
        public Task<IEnumerable<PersonResource>> all();

        public Task<PersonResource> show(string id);

        public Task store(Person person);

        public Task update(string id, Person person);

        public Task delete(string id);

        public List<Person> fetchPersons();

        public Person fetchPerson(string id);

        public Person storePerson(Person person);

        public Person updatePerson(string id, Person person);

        public Person deletePerson(string id);
    }
}