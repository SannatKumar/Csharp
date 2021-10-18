using System;
using System.Collections.Generic;
using System.Text;

namespace Firstprogram
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName +" "+ LastName;
        }

    }
}
