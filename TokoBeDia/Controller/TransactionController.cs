using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handler;
using TokoBeDia.Model;

namespace TokoBeDia.Controller
{
    public class TransactionController
    {
        public static HeaderTransaction getTransaction (int transactionId)
        {
            return TransactionHandler.getTransaction(transactionId);
        }

        public static List<DetailTransaction> detailList(int transactionId)
        {
            return TransactionHandler.getDetailTransaction(transactionId);
        }

        public static DataSet1 getDataSetForReport()
        {
            DataSet1 dataset = new DataSet1();
            var headerTransaction = dataset.HeaderTransaction;

            List<HeaderTransaction> header = TransactionHandler.getAllHeaderTransaction();
            foreach(HeaderTransaction h in header)
            {
                var row = headerTransaction.NewRow();
                row["TransactionID"] = h.ID;
                row["Transaction Date"] = h.date;
                row["UserID"] = h.userID;
                row["User Name"] = h.User.userName;
                row["PaymentTypeID"] = h.paymentTypeID;
                row["Payment Type"] = h.PaymentType.type;
                headerTransaction.Rows.Add(row);


                var detailTransaction = dataset.DetailTransaction;
                int id = Convert.ToInt32(h.ID);
                List<DetailTransaction> details = TransactionHandler.getDetailTransaction(h.ID);
                foreach(DetailTransaction d in h.DetailTransactions)
                {
                    if (h.ID == d.transactionID)
                    {
                        var rowdetail = detailTransaction.NewRow();
                        rowdetail["TransactionID"] = d.transactionID;
                        rowdetail["ProductID"] = d.productID;
                        rowdetail["Product Name"] = d.Product.productName;
                        rowdetail["Price"] = d.Product.productPrice;
                        rowdetail["Quantity"] = d.productID;
                        rowdetail["Subtotal"] = d.Product.productPrice * d.quantity;
                        detailTransaction.Rows.Add(rowdetail);
                    }
                }
            }
            return dataset;
        }
    }
}