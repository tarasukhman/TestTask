using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class DataModel
    {
        public string VisitorFirstName { get; set; }
        public string VisitorLastName { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public int CityRate { get; set; }
        public string CityComment { get; set; }
    }
}
