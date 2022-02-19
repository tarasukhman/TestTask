using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Models;
using TestTask.ViewModels;

namespace TestTask.Services
{
    public interface IService
    {
        Task<IEnumerable<DataViewModel>> GetAllData();
        IEnumerable<DataViewModel> GetDataWithFilter(string filter);
    }
}
