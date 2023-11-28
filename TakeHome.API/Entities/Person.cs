namespace TakeHome.API.Entities
{
    public class Person
    {
        public Person() { }
        public Person(int id, string fullName, string job)
        {
            Id = id;
            FullName = fullName;
            Job = job;
        }
        public int Id { get; set; }

        public string? FullName { get; set; }

        public string? Job { get; set; }
    }
}
