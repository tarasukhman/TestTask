using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestTask.Context;
using TestTask.Extensions;
using TestTask.Models;
using TestTask.ViewModels;

namespace TestTask.Services
{
    public class Service : IService
    {
        private readonly ApplicationDbContext _context;
        public Service(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DataViewModel>> GetAllData()
        {
            var data = await _context.Countries
                .Include(x=>x.Cities)
                .ThenInclude(x=>x.Visits)
                .ThenInclude(x=>x.VisitVisitors)
                .ThenInclude(x=>x.Visitor)
                .ToListAsync();

            return data.MapToDataViewModels();
        }

        public IEnumerable<DataViewModel> GetDataWithFilter(string filter)
        {
            var data = GetAllData().Result;

            if (!string.IsNullOrEmpty(filter))
                return data.Where(x => x.CountryName.Equals(filter, StringComparison.OrdinalIgnoreCase));

            return data;
        }

    }
}
