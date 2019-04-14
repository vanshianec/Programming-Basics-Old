using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp73
{
    class Family
    {
        List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
           
        }

    }
}
