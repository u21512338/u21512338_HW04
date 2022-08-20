using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21512338_HW04.Models
{
    public class Money : Donation
    {
        private int mCardNum;
        private DateTime mExpiray;
        private int mCvc;
        private string mBillingAddress;
        private double mAmount;

        public int CardNum { get => mCardNum; set => mCardNum = value; }
        public DateTime Expiray { get => mExpiray; set => mExpiray = value; }
        public int Cvc { get => mCvc; set => mCvc = value; }
        public string BillingAddress { get => mBillingAddress; set => mBillingAddress = value; }
        public double Amount { get => mAmount; set => mAmount = value; }

        public Money()
        {
        }

        public Money(string name, string surname, int num, string email, string msg, double amount, int cardnum, DateTime exp, int cvc, string address) : base(name, surname, num, email, msg)
        {
            CardNum = cardnum;
            Expiray = exp;
            Cvc = cvc;
            BillingAddress = address;
            Amount = amount;
        }

        public override double getAverage()
        {
            double average;
            average = Amount / 1;
            return Math.Round(average, 2);
        }

        public override string fullName()
        {
            return base.fullName() + "donated R" + this.Amount;
        }
    }
}