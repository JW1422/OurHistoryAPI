using System.Collections.Generic;
using System.Threading.Tasks;
using OurHistory.Models.Models.History;

namespace OurHistory.Core.Services.Interfaces
{
    public interface IHistoryService
    {
        Task<List<HistoricalPoint>> GetHistoricalPoints();
    }
}