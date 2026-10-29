using ApiTestApp.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace ApiTestApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestInformationService _testInfromationService;

        public TestController(ITestInformationService testinfromationService)
        {
            _testInfromationService = testinfromationService;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestInfo(int id)
        {
            try {

                var result = await _testInfromationService.GetTestInfoAsync(id);

                return new OkObjectResult(result);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
