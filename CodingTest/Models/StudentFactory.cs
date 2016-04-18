using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTest.Models
{
    public static class StudentFactory
    {
        public static Student Create(Student.StudentType type)
        {
            switch (type)
            {
                case Student.StudentType.Undergraduate:
                    return new UndergraduateStudent();
                case Student.StudentType.Graduate:
                    return new GraduateStudent();
                case Student.StudentType.Doctorate:
                    return new DoctorateStudent();
                default:
                    return null;
            }
        }
    }
}