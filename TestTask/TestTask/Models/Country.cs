using System.Collections;
using System.Collections.Generic;

namespace TestTask.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<CountryVisitor> CountryVisitors { get; set; }
    }
}
