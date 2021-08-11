using System.Collections.Generic;
using System.Threading.Tasks;

namespace techlink.Persons
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> all();

        Task<Person> show(string id);

        Task store(Person person);

        Task update(string id, Person person);

        Task delete(string id);
    }
}