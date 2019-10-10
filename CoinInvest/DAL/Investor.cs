using CoinInvest.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinInvest.DAL
{
    public class Investor
    {
        public int ID { get; set; }

        public string email { get; set; }

        public DateTime DateRegistered { get; set; }

        public bool IsConfirmed { get; set; }

        public DateTime DateConfirmed { get; set; }

        public string firstName { get; set; }

        public string userID { get; set; }

        public ApplicationUser user { get; set; }
    }
}