using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class HeaderTransactionRepository
    {
        static TokoBeDiaContainer db = new TokoBeDiaContainer();

        public static int newTransaction(int userID, DateTime date, int paymentTypeID)
        {
            HeaderTransaction ht = HeaderTransactionFactory.newTransaction(userID, date, paymentTypeID);
            db.HeaderTransactions.Add(ht);
            db.SaveChanges();
            return ht.ID;
        }

        public static HeaderTransaction getTransaction(int ID)
        {
            HeaderTransaction ht = (from x in db.HeaderTransactions where x.ID == ID select x).FirstOrDefault();
            return ht;
        }
        
        //ngambil smua 
        public static List<HeaderTransaction> getAll()
        {
            return db.HeaderTransactions.ToList();
        }


    }
}