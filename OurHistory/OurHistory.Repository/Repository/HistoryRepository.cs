using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OurHistory.Models.Models.History;
using OurHistory.Repository.Interface;

namespace OurHistory.Repository.Repository
{
    public class HistoryRepository : IHistoryRepository
    {
        public async Task<List<HistoricalPoint>> GetHistoricalPoints()
        {
            return new List<HistoricalPoint>
            {
                new HistoricalPoint
                {
                    Id = 1,
                    Title = "Capper Pass",
                    Latitude = 53.71016293067785,
                    Longitude = -0.5279932470206731,
                    Description = "Capper Pass and Son Ltd. was a British smelting and refining company specialising in non-ferrous metal refining, particularly tin. Originally established in Bristol in the early 1800s, the company relocated to a site on the banks of the Humber Estuary at Melton, East Riding of Yorkshire, in the 1930s, with the Bristol factories closing in the 1960s. Rio Tinto Zinc acquired the firm in the 1960s.",
                    HistoricalDate = new DateTime(1937, 1, 1)                    
                }
            };
        }
    }
}