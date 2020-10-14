using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class DetailTransactionFactory
    {
        public static DetailTransaction addNewDetail(int transactionID, int productID, int quantity)
        {
            DetailTransaction dt = new DetailTransaction();
            dt.transactionID = transactionID;
            dt.productID = productID;
            dt.quantity = quantity;
            return dt;
        }
    }
}