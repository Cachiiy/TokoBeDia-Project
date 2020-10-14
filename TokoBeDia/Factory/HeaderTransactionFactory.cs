using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class HeaderTransactionFactory
    {
        public static HeaderTransaction newTransaction(int userID, DateTime date, int paymentTypeID)
        {
            HeaderTransaction ht = new HeaderTransaction();
            ht.userID = userID;
            ht.date = date;
            ht.paymentTypeID = paymentTypeID;
            return ht;
        }
    }
}