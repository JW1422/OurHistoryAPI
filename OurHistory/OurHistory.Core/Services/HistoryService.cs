using System.Collections.Generic;
using System.Threading.Tasks;
using OurHistory.Core.Services.Interfaces;
using OurHistory.Models.Models.History;
using OurHistory.Repository.Interface;

namespace OurHistory.Core.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository _historyRepository;
        
        public HistoryService(IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }
        
        public async Task<List<HistoricalPoint>> GetHistoricalPoints()
        {
            var response = await _historyRepository.GetHistoricalPoints();
            
            return response; // Goes off to repository
        }
    }
}