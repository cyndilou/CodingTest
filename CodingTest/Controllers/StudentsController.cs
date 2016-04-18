using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodingTest.Models;

namespace CodingTest.Controllers
{
    public class StudentsController : ApiController
    {
        // Hard coded list of students.  Would be better to use some data source (ex. database or xml file).
        Student[] students = new Student[]
        {
            new UndergraduateStudent { Name = "Bob", PhoneNumber = "555-555-5555", Address = "123 Here" },
            new UndergraduateStudent { Name = "Alice", PhoneNumber = "123-456-7890", Address = "555 There" },
            new GraduateStudent { Name = "Joe", PhoneNumber = "913-555-5555", Address = "111 Anywhere" },
            new DoctorateStudent { Name = "Sue", PhoneNumber = "816-123-4567", Address = "222 Nowhere" }
        };

        public IEnumerable<Student> GetStudents()
        {
            return students;
        }
    }
}
