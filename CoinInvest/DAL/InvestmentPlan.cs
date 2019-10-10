using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinInvest.DAL
{
    public class InvestmentPlan
    {
        public int ID { get; set; }

        public string InvestmentName { get; set; }

        public double Amount { get; set; }

        public int MaturityDuration { get; set; }

       
    }
}