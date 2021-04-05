using System.Collections.Generic;
using System.Threading.Tasks;
using OurHistory.Models.Models.History;
using OurHistory.Repository.Interface;

namespace OurHistory.Repository.Repository
{
    public class HistoryRepository : IHistoryRepository
    {
        public async Task<List<HistoryPoint>> GetHistoricalPoints()
        {
            return new List<HistoryPoint>();
        }
    }
}