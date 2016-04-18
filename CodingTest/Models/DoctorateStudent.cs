using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTest.Models
{
    public class DoctorateStudent : Student
    {
        public DoctorateStudent()
        {
            studentType = StudentType.Doctorate;
        }

        public override int BuyCafeteriaCredit()
        {
            CafeteriaCredits += 3;
            return CafeteriaCredits;
        }

        public override bool RegisterForClass()
        {
            // do something to indicate student has registered for the class
            return true;
        }

        public override string RetrieveTranscript()
        {
            return "Doctorate Student Transcript";
        }
    }
}