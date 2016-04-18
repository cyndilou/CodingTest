using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTest.Models
{
    public class UndergraduateStudent : Student
    {
        public UndergraduateStudent()
        {
            studentType = StudentType.Undergraduate;
        }

        public override int BuyCafeteriaCredit()
        {
            CafeteriaCredits++;
            return CafeteriaCredits;
        }

        public override bool RegisterForClass()
        {
            // do something to indicate student has registered for the class
            return true;
        }

        public override string RetrieveTranscript()
        {
            return "Undergraduate Student Transcript";
        }
    }
}