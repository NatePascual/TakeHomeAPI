using AutoMapper;
using TakeHome.API.Controllers;
using TakeHome.API.Entities;

namespace TakeHome.API.Profiles
{
    public class PersonProfile: Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonModel>();
        }

    }
}
