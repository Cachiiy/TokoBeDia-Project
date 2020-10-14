using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.Handler
{
    public class TransactionHandler
    {

        //ngambil per id 
        public static HeaderTransaction getTransaction (int transactionId)
        {
            return HeaderTransactionRepository.getTransaction(transactionId);
        }

        public static List<DetailTransaction> getDetailTransaction(int transactionId)
        {
            return DetailTransactionRepository.getDetailTransaction(transactionId);
        }

        //ngambil smua 
        public static List<HeaderTransaction> getAllHeaderTransaction()
        {
            return HeaderTransactionRepository.getAll();
        }
    }
}