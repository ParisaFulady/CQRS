using CQRS._03.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;

namespace CQRS
{
    class Program
    {
        static void Main(string[] args)
        {
            var OptionBuilderWrite = new DbContextOptionsBuilder<PersonContext>();
            OptionBuilderWrite.UseSqlServer("Server=.;Database=CQRSDBWrite;User Id = sa;Password = ABCabc123456;");

            var OptionBuilderRead = new DbContextOptionsBuilder<PersonContext>();
            OptionBuilderRead.UseSqlServer("Server=.;Database=CQRSReadDB;User Id = sa;Password = ABCabc123456;");

            var ctxWrite = new PersonContext(OptionBuilderWrite.Options);
            var ctxRead = new PersonContext(OptionBuilderRead.Options);

            ctxWrite.Database.EnsureDeleted();
            ctxRead.Database.EnsureDeleted();

            ctxWrite.Database.EnsureCreated();
            ctxRead.Database.EnsureCreated();

            var ReadRepo = new PersonReadRepository(ctxRead);
            var WriteRepo = new PersonWriteRepository(ctxWrite);

            WriteRepo.Add(new _01.Entities.Person
            {
                FirstName="Hassan",
                LastName="Asil"
            });

            var list = ReadRepo.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine($"FirstName:{ item.FirstName} lastName:{ item.LastName}");
            }

            Console.ReadLine();
        }
    }
}
