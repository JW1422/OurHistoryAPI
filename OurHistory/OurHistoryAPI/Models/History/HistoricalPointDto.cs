using OurHistory.Models.Models.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurHistoryAPI.Models.History
{
    public class HistoricalPointDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime HistoricalDate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public List<string> HistoricalKeys { get; set; }
        public List<string> HistoricalInfo { get; set; }

        public static HistoricalPointDto FromDomain(HistoricalPoint domain)
        {
            if (domain == null)
                return null;

            return new HistoricalPointDto
            {
                Id = domain.Id,
                Title = domain.Title,
                HistoricalDate = domain.HistoricalDate,
                Latitude = domain.Latitude,
                Longitude = domain.Longitude,
                Description = domain.Description,
                HistoricalKeys = domain.HistoricalKeys,
                HistoricalInfo = domain.HistoricalInfo
            };
        }
    }
}
