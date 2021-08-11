using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using techlink.Db;

namespace techlink.Persons
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IDataContext _context;

        public PersonRepository(IDataContext dataContext) {
            _context = dataContext;
        }

        public async Task<IEnumerable<Person>> all()
        {
            return await _context.Persons.ToListAsync();
        }

        public async Task<Person> show(string id)
        {
            return await this.findPersonById(id);
        }

        public async Task store(Person person)
        {
            _context.Persons.Add(person);   
            await _context.SaveChangesAsync();
        }

        public async Task update(string id, Person person)
        {
            Person oldPerson = await this.findPersonById(id);
            oldPerson.Name = person.Name;
            oldPerson.email = person.email;
            oldPerson.password = person.password;
            await _context.SaveChangesAsync();
        }

        public async Task delete(string id) 
        {
            Person person = await this.findPersonById(id);
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();
        }

        private async Task<Person> findPersonById(string id)
        {
            Person person = await _context.Persons.FindAsync(id);
            if(person == null)
            {
                throw new NullReferenceException();
            }

            return person;
        }
    }
}