using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab1.Models
{
    // ========================================= PERSON ========================================= //
    public class Person
    {
        string fname;
        string lname;
        DateTime dateOfBirth;
        char gender;

        public Person() {}
        public string getfname() { return fname; }
        public string getlname() { return lname; }
        public DateTime getdob() { return dateOfBirth; }
        public char getgender() { return gender; }
    }

    
}