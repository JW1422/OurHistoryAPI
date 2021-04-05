using System.Collections.Generic;
using System.Threading.Tasks;
using OurHistory.Models.Models.History;

namespace OurHistory.Repository.Interface
{
    public interface IHistoryRepository
    {
        Task<List<HistoryPoint>> GetHistoricalPoints();
    }
}