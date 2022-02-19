using System.Collections.Generic;
using System.Linq;
using TestTask.Models;
using TestTask.ViewModels;

namespace TestTask.Extensions
{
    public static class MapExtension
    {
        public static IEnumerable<DataViewModel> MapToDataViewModels(this List<Country> data)
        {
            var dataViewModels = new List<DataViewModel>();
            
            foreach (var country in data)
            {
                foreach (var city in country.Cities)
                {
                    foreach (var visit in city.Visits)
                    {
                        dataViewModels.AddRange(visit.VisitVisitors.Select(visitVisitor => new DataViewModel()
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

            return dataViewModels;
        }
    }
}
