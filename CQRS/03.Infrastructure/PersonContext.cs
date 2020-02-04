using CQRS._01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS._03.Infrastructure
{
   public class PersonContext:DbContext
    {
        public DbSet<Person> Person { get; set; }
        public PersonContext(DbContextOptions<PersonContext> option) : base(option)
        {

        }
       
    }
}
