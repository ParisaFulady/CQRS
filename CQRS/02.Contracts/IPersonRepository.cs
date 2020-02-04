using CQRS._01.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS._02.Contracts
{
    public interface IPersonReadRepository
    {
        Person Find(int id);
        List<Person> GetAll();
    
    }
    public interface IPersonWriteRepository
    {
    
        void Add(Person person);
        void Update(Person person);
    }
}
