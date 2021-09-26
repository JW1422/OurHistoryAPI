using System;
using System.Collections.Generic;

namespace OurHistory.Models.Models.History
{
    public class HistoricalPoint
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime HistoricalDate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<string> HistoricalKeys { get; set; }
        public List<string> HistoricalInfo { get; set; }
    }
}