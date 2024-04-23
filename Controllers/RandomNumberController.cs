using Microsoft.AspNetCore.Mvc;

namespace VueBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        [HttpGet(Name = "GetRandomNumber")]
        public int Get()
        {
            return new RandomNumber { Number = Random.Shared.Next() }.Number;
        }
    }
}
