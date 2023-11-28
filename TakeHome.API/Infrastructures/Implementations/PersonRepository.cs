using TakeHome.API.Entities;
using TakeHome.API.Infrastructures.Interfaces.Specifications;
using System.Linq.Expressions;

namespace TakeHome.API.Infrastructures.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        public PersonRepository() { }
        public Task<IEnumerable<Person>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var people = Data.TestData.GeneratePeople.People.AsEnumerable();

            return Task.FromResult(people);
        }

        public Task<Person> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var person = Data.TestData.GeneratePeople.People.FirstOrDefault(x =>x.Id == id);

            return Task.FromResult(person);
        }

        
    }
}
