using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace DAL.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Visit> Visits { get; set; }

    }
}
