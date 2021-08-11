using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

using techlink.Persons;

namespace techlink.Persons
{
    public class PersonService : IPersonService
    {
        private readonly List<Person> persons = new List<Person>();

        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public PersonService()
        {
            persons.Add(new Person("123asd", "Ram Shrestha", "ram_shrestha@gmail.com"));
            persons.Add(new Person("asd123", "Shyam Shrestha", "shyam_shrestha@gmail.com"));
        }

        public async Task<IEnumerable<PersonResource>> all()
        {
            List<PersonResource> persons = new List<PersonResource>();

            foreach(Person person in await _personRepository.all()) 
            {
                persons.Add(new PersonResource(person.id, person.Name, person.email, person.createdAt, person.updatedAt));
            }

            return persons;
        }

        public async Task<PersonResource> show(string id)
        {
            Person person = await _personRepository.show(id);
            PersonResource personResource = new PersonResource(person.id, person.Name, person.email, person.createdAt, person.updatedAt);
            return personResource;
        }

        public async Task store(Person person)
        {
            await _personRepository.store(this.hashPassword(person));
        }

        public async Task update(string id, Person person) 
        {
            await _personRepository.update(id, this.hashPassword(person));
        }

        public async Task delete(string id) 
        {
            await _personRepository.delete(id);
        }

        private Person hashPassword(Person person)
        {
            person.password = BC.HashPassword(person.password);
            return person;
        }

        public List<Person> fetchPersons()
        {
            Person p = new Person();
            p.id = "ade";
            p.Name = "Dipesh Shrestha";
            p.email = "dipesh_shrestha@gmail.com";
            this.persons.Add(p);
            return this.persons;
        }

        public Person fetchPerson(string id)
        {
            return this.persons.Find(p => p.id == id);
        }

        public Person storePerson(Person person)
        {
            this.persons.Add(person);
            return person;
        }

        public Person updatePerson(string id, Person person) 
        {
            Person p = this.persons.Find(p => p.id == id);        
            p.Name = person.Name;
            p.email = person.email;
            return person;
        }

        public Person deletePerson(string id)
        {
            Person p = this.persons.Find(p => p.id == id);   
            this.persons.Remove(p);
            return p;
        }
    }
}