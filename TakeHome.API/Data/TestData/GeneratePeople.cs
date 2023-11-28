using System;
using TakeHome.API.Entities;

namespace TakeHome.API.Data.TestData
{
    public class GeneratePeople
    {
        public static IList<Person> People { get; set; } = new List<Person>();
        public static void ExecuteNames()
        {
            People = new List<Person>
            {
                new Person(1,"Lily Hill","Human Resources Manager"),
                new Person(2,"Connor Cajulao","Medical Technologist"),
                new Person(3,"Alex Johnson","Social Media Coordinator"),
                new Person(4,"Lucas Doe","Registered Veterinary Technician"),
                new Person(5,"Alex Lewis","Police Officer"),
                new Person(6,"Jake Brooks","Project Manager"),
                new Person(7,"Ethan Garcia","UX Designer"),
                new Person(8,"Jackson White","Marketing Manager"),
                new Person(9,"William Cooper","Registered Nurse"),
                new Person(10,"Sara Simmons","Accountant"),
                new Person(11,"Lily Brooks","Medical Technologist"),
                new Person(12,"Aria Foster","Event Coordinator"),
                new Person(13,"Victoria Wright","Biomedical Scientist"),
                new Person(14,"Scarlett Taylor","Police Officer"),
                new Person(15,"Lucas Perry","Journalist"),
                new Person(16,"Chris Simmons","Graphic Designer"),
                new Person(17,"Ryan Lewis","Project Manager"),
                new Person(18,"Caleb Lee","Registered Veterinary Technician"),
                new Person(19,"Aria Palmer","Graphic Designer"),
                new Person(20,"Logan Foster","Registered Nurse"),
                new Person(21,"Max Mitchell","IT Specialist"),
                new Person(22,"Jessica Foster","Mechanical Engineer"),
                new Person(23,"Jackson Simmons","Data Analyst"),
                new Person(24,"Chris Wright","Web Developer"),
                new Person(25,"Nina Mitchell","Software Engineer"),
                new Person(26,"Benjamin Rivera","Biomedical Engineer"),
                new Person(27,"Sophia Brooks","Registered Dietitian"),
                new Person(28,"Mia Johnson","Event Planner"),
                new Person(29,"Jessica Adams","Occupational Therapist"),
                new Person(30,"Haley Miller","Sales Associate"),
                new Person(31,"Mia Lee","Fitness Trainer"),
                new Person(32,"Sara Cooper","Project Manager"),
                new Person(33,"Nathan Hill","Marketing Manager"),
                new Person(34,"Amelia Wilson","Electrician"),
                new Person(35,"Jackson Mitchell","Librarian"),
                new Person(36,"Nathan White","Customer Service Representative"),
                new Person(37,"Connor Cooper","Phlebotomist"),
                new Person(38,"William Mitchell","Librarian"),
                new Person(39,"Nina Cajulao","Mechanical Engineer"),
                new Person(40,"Eva Anderson","Fashion Designer"),
                new Person(41,"Andrew Garcia","Data Analyst"),
                new Person(42,"Amelia Anderson","Pharmacist"),
                new Person(43,"Isaac Price","Nutritionist"),
                new Person(44,"Jessica Anderson","Event Planner"),
                new Person(45,"Ethan Scott","Radiologic Technologist"),
                new Person(46,"Jake Anderson","Digital Marketing Specialist"),
                new Person(47,"Elijah Wilson","Web Developer"),
                new Person(48,"Natalie Doe","Electrician"),
                new Person(49,"Max Brooks","Architect"),
                new Person(50,"Owen Melo","Physical Therapist"),
                new Person(51,"Owen Garcia","Digital Marketing Specialist"),
                new Person(52,"Natalie Lee","Biomedical Scientist"),
                new Person(53,"Elijah Anderson","Registered Nurse"),
                new Person(54,"Avery Perry","Fashion Designer"),
                new Person(55,"Samuel Lee","Civil Engineer"),
                new Person(56,"Amelia Hill","Medical Technologist"),
                new Person(57,"William Melo","Civil Engineer"),
                new Person(58,"Owen Taylor","Biomedical Engineer"),
                new Person(59,"Hannah Perry","Civil Engineer"),
                new Person(60,"Isaac Lee","Event Coordinator")
            };
        }
    }
}
