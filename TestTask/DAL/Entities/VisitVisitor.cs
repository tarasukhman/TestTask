namespace DAL.Entities
{
    public class VisitVisitor
    {
        public int VisitId { get; set; }
        public Visit Visit { get; set; }

        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
