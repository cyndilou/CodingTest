using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTest.Models
{
    public class GraduateStudent : Student
    {
        public GraduateStudent()
        {
            studentType = StudentType.Graduate;
        }

        public override int BuyCafeteriaCredit()
        {
            CafeteriaCredits += 2;
            return CafeteriaCredits;
        }

        public override bool RegisterForClass()
        {
            // do something to indicate student has registered for the class
            return true;
        }

        public override string RetrieveTranscript()
        {
            return "Graduate Student Transcript";
        }
    }
}