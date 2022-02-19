using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Extensions;
using BLL.Models;
using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class Service : IService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public Service(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DataModel>> GetAllData()
        {
            var data = await _context.Countries
                .Include(x=>x.Cities)
                .ThenInclude(x=>x.Visits)
                .ThenInclude(x=>x.VisitVisitors)
                .ThenInclude(x=>x.Visitor)
                .ToListAsync();

            return data.MapToDataViewModels();
        }

        public IEnumerable<DataModel> GetDataWithFilter(string filter)
        {
            var data = GetAllData().Result;

            if (!string.IsNullOrEmpty(filter))
                return data.Where(x => x.CountryName.Equals(filter, StringComparison.OrdinalIgnoreCase));

            return data;
        }

    }
}
