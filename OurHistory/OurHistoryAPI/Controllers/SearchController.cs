using Microsoft.AspNetCore.Mvc;

namespace OurHistoryAPI.Controllers
{
    [Route("Search")]
    public class SearchController
    {
        [HttpGet("")]
        public IActionResult Search()
        {
            return new JsonResult(new
            {
                test = "test"
            });
        }
    }
}