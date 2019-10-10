using CoinInvest.DAL;
using CoinInvest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoinInvest.Services
{
    public class Create
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public bool CreateInvestor(string userid)
        {
            var user = db.Users.Where(x => x.Id == userid).FirstOrDefault();

            Investor newInvestor = new Investor
            {
                DateRegistered = DateTime.Now.ToLocalTime(),
                IsConfirmed = false,
                email = user.Email,
                firstName = user.FirstName,
                DateConfirmed = DateTime.Now,
                userID = userid,

            };

            using (db)
            {
                using (DbContextTransaction transaction  = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.investors.Add(newInvestor);
                        db.SaveChanges();
                        transaction.Commit();

                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                       
                    }
                }
            }
           
        }
    }
}