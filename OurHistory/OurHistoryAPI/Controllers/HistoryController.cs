using Microsoft.AspNetCore.Mvc;

namespace OurHistoryAPI.Controllers
{
    [Route("History")]
    public class HistoryController
    {
        [HttpGet("Points")]
        public IActionResult GetHistoryPoints() // potentially need to add add parameters for location and radius
        {
            return new JsonResult(new
            {
                test = "test"
            });
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