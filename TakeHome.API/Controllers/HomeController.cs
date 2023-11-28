using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TakeHome.API.Infrastructures.Interfaces.Specifications;

namespace TakeHome.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public HomeController(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Use Case 1 - Returns Hello World Message plus version
        [HttpGet("greet")]
        public ActionResult<string> GetHelloWorld()
        {
            var version = typeof(Program).Assembly.GetName().Version.ToString();
            return $"Hello World! API Version: {version}";
        }

       
    }

  
}
