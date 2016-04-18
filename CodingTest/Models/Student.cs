using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTest.Models
{
    public class Student
    {
        public enum StudentType
        {
            Undergraduate,
            Graduate,
            Doctorate
        };

        public Student()
        {
            CafeteriaCredits = 0;
        }

        protected StudentType studentType   ;
        public string Type
        {
            get
            {
                switch (studentType)
                {
                    case StudentType.Undergraduate:
                        return "Undergraduate";
                    case StudentType.Graduate:
                        return "Graduate";
                    case StudentType.Doctorate:
                        return "Doctorate";
                    default:
                        return String.Empty;
                }
            }
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        // For simplicity sake, I'm using a string for the address.  This would be better served
        // as an object with properties for Street, City, State, etc
        public string Address { get; set; }

        public int CafeteriaCredits { get; set; }

        public virtual int BuyCafeteriaCredit()
        {
            return CafeteriaCredits;
        }

        public virtual bool RegisterForClass()
        {
            return false;
        }

        public virtual string RetrieveTranscript()
        {
            return String.Empty;
        }
    }
}