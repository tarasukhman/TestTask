namespace DAL.Entities
{
    public class CountryVisitor
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }
        
        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
