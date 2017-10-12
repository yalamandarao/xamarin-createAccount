using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  CreateAccount
{
    public class Member
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }

        public Member(string firstName, string middleName, string lastName, DateTime dateTime)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateTime = dateTime;
        }
    }
}
