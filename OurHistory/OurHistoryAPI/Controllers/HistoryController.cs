using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OurHistory.Core.Services.Interfaces;
using OurHistoryAPI.Models.History;

namespace OurHistoryAPI.Controllers
{
    [Route("History")]
    public class HistoryController
    {
        private readonly IHistoryService _historyService;
        
        public HistoryController(IHistoryService historyService)
        {
            _historyService = historyService;
        }
        
        [HttpGet("Points")]
        public async Task<IActionResult> GetHistoryPoints() // potentially need to add add parameters for location and radius
        {
            var response = await _historyService.GetHistoricalPoints();
            
            return new JsonResult(response.Select(HistoricalPointDto.FromDomain).ToList());
        }

        [HttpGet("Points/{id}")]
        public IActionResult GetHistoryPointById()
        {
            return new JsonResult(new
            {
                test = "test"
            });
        }
    }
}