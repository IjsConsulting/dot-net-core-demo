using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private static readonly string[] Answers = new[]
        {
            "Yes", "No"
        };

        [HttpGet]
        public string GetAnswer()
        {
            return Answers[1];
        }

        private void Run()
        {
        }
    }
}