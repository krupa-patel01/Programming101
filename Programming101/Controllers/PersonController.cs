using Microsoft.AspNetCore.Mvc;
using Programming101.Models;
using System;

namespace Programming101.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            Person person = new Person { Name = "Krupa" };
            Employee employee = new Employee { Age = 24 };
            Student student = new Student { FavoriteSubject = "Science" };

            String PersonProfile = "My name is " + person.Name + ". I am a student and my favorite subject is " + student.FavoriteSubject + ". I am " + employee.Age + " years old.";

            return PersonProfile;
        }
    }
}
