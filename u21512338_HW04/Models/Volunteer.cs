using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21512338_HW04.Models
{
    public class Volunteer
    {
        public string volunteerName { get; set; }
        public string volunteerSurname { get; set; }
        public string volunteerNumber { get; set; }
        public string volunteerEmail { get; set; }

        public Volunteer()
        {
            
        }

        public Volunteer(string name, string surname, string number, string email)
        {
            volunteerName = name;
            volunteerSurname = surname;
            volunteerNumber = number;
            volunteerEmail = email;
        }
    }
}