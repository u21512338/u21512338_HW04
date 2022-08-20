using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21512338_HW04.Models
{
    public class Food : Donation
    {
        private string fDescription;
        private int fQuantity;
        private double fValue;
        private string fWarning;       

        public string Description { get => fDescription; set => fDescription = value; }
        public int Quantity { get => fQuantity; set => fQuantity = value; }
        public double Value { get => fValue; set => fValue = value; }
        public string Warning { get => fWarning; set => fWarning = value; }

        public Food()
        {
        }

        public Food(string name, string surname, int num, string email, string msg, string desc, int qty, double value, string warning) : base(name, surname, num, email, msg)
        {
            Description = desc;
            Quantity = qty;
            Value = value;
            Warning = warning;
        }

        public override double getAverage()
        {
            double average;
            average = Value / Quantity;
            return Math.Round(average, 2);
        }

        public override string fullName()
        {
            return base.fullName() + "donated" + this.Quantity + this.Description;
        }
    }
}