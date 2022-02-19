using System.Collections.Generic;
using System.Linq;
using BLL.Models;
using DAL.Entities;

namespace BLL.Extensions
{
    public static class MapExtension
    {
        public static IEnumerable<DataModel> MapToDataViewModels(this List<Country> data)
        {
            var dataModels = new List<DataModel>();
            
            foreach (var country in data)
            {
                foreach (var city in country.Cities)
                {
                    foreach (var visit in city.Visits)
                    {
                        dataModels.AddRange(visit.VisitVisitors.Select(visitVisitor => new DataModel()
                        {
                            VisitorFirstName = visitVisitor.Visitor.FirstName,
                            VisitorLastName = visitVisitor.Visitor.LastName,
                            CountryName = country.Name,
                            CityName = city.Name,
                            CityRate = visit.Rate,
                            CityComment = visit.Comment
                        }));
                    }
                }
            }

            return dataModels;
        }
    }
}
