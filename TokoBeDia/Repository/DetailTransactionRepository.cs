using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class DetailTransactionRepository
    {
        static TokoBeDiaContainer db = new TokoBeDiaContainer();

        public static void newTransactionDetail(int transactionID, int productID, int quantity)
        {
            DetailTransaction dt = DetailTransactionFactory.addNewDetail(transactionID, productID, quantity);
            db.DetailTransactions.Add(dt);
            db.SaveChanges();
        }

        public static List<DetailTransaction> getDetailTransaction(int transactionID)
        {
            List<DetailTransaction> detailList = (from x in db.DetailTransactions
                                                 where x.transactionID == transactionID
                                                 select x).ToList();
            return detailList;
        }
    }
}