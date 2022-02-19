using System.Collections.Generic;

namespace TestTask.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<VisitVisitor> VisitVisitors { get; set; }
    }
}
