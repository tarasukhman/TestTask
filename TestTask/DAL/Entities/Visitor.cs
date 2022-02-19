﻿using System.Collections.Generic;

namespace DAL.Entities
{
    public class Visitor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<CountryVisitor> CountryVisitors { get; set; }
        public ICollection<VisitVisitor> VisitVisitors { get; set; }
    }
}
