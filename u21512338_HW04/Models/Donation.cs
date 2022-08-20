using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21512338_HW04.Models
{
    public abstract class Donation
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public Donation()
        {

        }

        protected Donation(string name, string surname, int number, string email, string message)
        {
            Name = name;
            Surname = surname;
            Number = number;
            Email = email;
            Message = message;
        }

        public abstract double getAverage();

        public virtual string fullName()
        {
            return Name + " " + Surname;
        }
    }
}