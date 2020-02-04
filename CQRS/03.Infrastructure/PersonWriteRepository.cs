using CQRS._01.Entities;
using CQRS._02.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS._03.Infrastructure
{
    public class PersonWriteRepository : IPersonWriteRepository
    {
        private readonly PersonContext _personContext;
        public PersonWriteRepository(PersonContext personContext)
        {
            _personContext = personContext;
        }
        public void Add(Person person)
        {
            _personContext.Add(person);
            _personContext.SaveChanges();
        }

        public void Update(Person person)
        {
            _personContext.Update(person);
            _personContext.SaveChanges();
        }
    }
}
