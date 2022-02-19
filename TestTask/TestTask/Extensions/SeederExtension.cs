using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestTask.Models;

namespace TestTask.Extensions
{
    public static class SeederExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Ukraine"
                },
                new Country
                {
                    Id = 2,
                    Name = "Spain"
                },
                new Country
                {
                    Id = 3,
                    Name = "Germany"
                },
                new Country
                {
                    Id = 4,
                    Name = "France"
                }
            );

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Berlin",
                    CountryId = 3
                },
                new City
                {
                    Id = 2,
                    Name = "Kyiv",
                    CountryId = 1
                },
                new City
                {
                    Id = 3,
                    Name = "Paris",
                    CountryId = 4
                },
                new City
                {
                    Id = 4,
                    Name = "Madrid",
                    CountryId = 2
                }
            );
            modelBuilder.Entity<Visit>().HasData(
                new Visit
                {
                    Id = 1,
                    CityId = 1,
                    Comment = "sdsd",
                    Rate = 5
                },
                new Visit
                {
                    Id = 2,
                    CityId = 3,
                    Comment = "fdgf",
                    Rate = 3
                }
            );

            modelBuilder.Entity<Visitor>().HasData(
                new Visitor
                {
                    Id = 1,
                    FirstName = "Ivan",
                    LastName = "Ivanov"
                },
                new Visitor
                {
                    Id = 2,
                    FirstName = "Petro",
                    LastName = "Petrov"
                }
            );

            modelBuilder.Entity<CountryVisitor>().HasData(
                new CountryVisitor
                {
                    CountryId = 1,
                    VisitorId = 1
                },
                new CountryVisitor
                {
                    CountryId = 4,
                    VisitorId = 2
                }
            );

            modelBuilder.Entity<VisitVisitor>().HasData(
                new VisitVisitor
                {
                    VisitId = 1,
                    VisitorId = 2
                },
                new VisitVisitor
                {
                    VisitId = 2,
                    VisitorId = 1
                }
            );

        }
    }
}
