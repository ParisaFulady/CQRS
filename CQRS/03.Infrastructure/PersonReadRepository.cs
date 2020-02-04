using CQRS._01.Entities;
using CQRS._02.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS._03.Infrastructure
{
    public class PersonReadRepository : IPersonReadRepository
    {
        private readonly PersonContext _personContext;
        public PersonReadRepository(PersonContext personContext)
        {
            _personContext = personContext;
        }
       public Person Find(int id)
        {
            return _personContext.Person.Find(id);
           
        }

        public List<Person> GetAll()
        {
            return _personContext.Person.ToList();
        }
    }
}
