using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account
    {
        private double balance;
        private int accountSeller;
        private int accountGetter;
        public double Balance { get; set; }
        private double rate;
            public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }
}
