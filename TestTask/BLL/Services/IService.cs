using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Services
{
    public interface IService
    {
        Task<IEnumerable<DataModel>> GetAllData();
        IEnumerable<DataModel> GetDataWithFilter(string filter);
    }
}
