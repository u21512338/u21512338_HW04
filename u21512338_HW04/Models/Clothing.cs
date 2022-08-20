using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21512338_HW04.Models
{
    public class Clothing : Donation
    {
        private string cDescription;
        private int cQuantity;
        private double cValue;
        private string cAgeGroup;
        private string cQuality;        

        public string Description { get => cDescription; set => cDescription = value; }
        public int Quantity { get => cQuantity; set => cQuantity = value; }
        public double Value { get => cValue; set => cValue = value; }
        public string AgeGroup { get => cAgeGroup; set => cAgeGroup = value; }
        public string Quality { get => cQuality; set => cQuality = value; }

        public Clothing()
        {
        }

        public Clothing(string name, string surname, int num, string email, string msg, string cdesc, int cqty, double cvalue, string age, string quality) : base(name, surname, num, email, msg)
        {
            Description = cdesc;
            Quantity = cqty;
            Value = cvalue;
            AgeGroup = age;
            Quality = quality;
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