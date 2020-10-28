using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public PersonID pID{ get; private set;}

        public string status;

        static int counter=0;

        
        public int number { get; }

        public Person(PersonID pID, string status)
        {
            this.pID = pID;
            this.status = status;
            this.number=counter++;
        }

        public override string ToString()
        {
            string ret = "My name is " + pID.name + " " + pID.surname + " and i'm #"+number+"! I'm " + pID.age + " yo\n";

            if (default(int)!=pID.height) { ret += "my height is\n" + pID.height; } else { ret += "i don't know my height\n"; }
            if (default(DateTime)!=pID.birthDay) { ret += "my birthday is " + pID.birthDay; } else { ret += "i don't know my birthday"; }
            ret += " secondname = " + pID.secondName;

            return ret;
        }
    }
}
