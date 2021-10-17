using System;
using System.Collections.Generic;
using System.Text;

namespace Firstprogram
{
    public class Human
    {
        string middleName = "Kumar";
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName +" "+ LastName;
        }

    }
}
