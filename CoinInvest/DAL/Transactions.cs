using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinInvest.DAL
{
    public class Transactions
    {
        public int ID { get; set; }

        public DateTime TransactionDate { get; set; }

        public string InvestmentName { get; set; }

        public bool TransactionCompleted { get; set; }

        public InvestmentPlan Investmentplan { get; set; }

        public Investor InvestorID { get; set; }

        public Investor Investor { get; set; }
    }
}