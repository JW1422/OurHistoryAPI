using System;
using System.Collections.Generic;

namespace OurHistory.Models.Models.History
{
    public class HistoryPoint
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HistoricalDate { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public List<string> HistoricalKeys { get; set; }
        public List<string> HistoricalInfo { get; set; }
    }
}