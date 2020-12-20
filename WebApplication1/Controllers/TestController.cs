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

        [HttpGet]
        public string GetAnswer2()
        {
            return Answers[1];
        }

        [HttpGet]
        public string GetAnswer3()
        {
            return Answers[1];
        }
    }
}