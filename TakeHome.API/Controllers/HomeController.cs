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
        [HttpGet]
        public ActionResult<string> GetHelloWorld()
        {
            var version = typeof(Program).Assembly.GetName().Version.ToString();
            return $"Hello World! API Version: {version}";
        }

        //Use Case 2 - Returns a list of Person objects serialized to Json
        [HttpGet("people")]
        public ActionResult<string> GetPeopleAsync()
        {
            var query = _repository.GetAllAsync().Result.AsQueryable();

            var people = _mapper.Map<List<PersonModel>>(query);

            //Serialize to Json
            var serializePeople = JsonConvert.SerializeObject(people);

            return serializePeople.ToString();
        }

        //Use Case 3- Returns a Person using a unique id
        [HttpGet("person/{id}")]
        public ActionResult<PersonModel> GetPersonByIdAsync(int id)
        {
            var query = _repository.GetByIdAsync(id).Result;

            var person = _mapper.Map<PersonModel>(query);

            return person;
        }
    }

    public class PersonModel
    {
        public int Id { get; set; }

        public string? FullName { get; set; }
        public string? Job { get; set; }
    }
}
