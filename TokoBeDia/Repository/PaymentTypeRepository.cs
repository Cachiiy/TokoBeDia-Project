using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class PaymentTypeRepository
    {
        public static TokoBeDiaContainer db = new TokoBeDiaContainer();

        public static Boolean insertPaymentType (string type)
        {
            PaymentType pt = PaymentTypeFactory.createPaymentType(type);
            db.PaymentTypes.Add(pt);
            db.SaveChanges();

            return true;
        }

        public static PaymentType checkPaymentType(string type)
        {
            PaymentType pt = db.PaymentTypes.Where(x => x.type == type).FirstOrDefault();

            return pt;
        }

        public static List<PaymentType> getPaymentType()
        {
            return db.PaymentTypes.ToList();
        }

        public static PaymentType checkPaymentTypeId(int id)
        {
            PaymentType pt = db.PaymentTypes.Where(x => x.paymentID == id).FirstOrDefault();

            return pt;
        }

        public static int getPaymentTypeID(string type)
        {
            int pt = (from x in db.PaymentTypes where x.type == type select x.paymentID).FirstOrDefault();
            return pt;
        }

        public static Boolean removePaymentType(int id)
        {
            PaymentType pt = db.PaymentTypes.Where(x => x.paymentID == id).FirstOrDefault();
            db.PaymentTypes.Remove(pt);
            db.SaveChanges();

            return true;
        }

        public static Boolean updatePaymentType(int id, string type)
        {
            PaymentType pt = db.PaymentTypes.Where(x => x.paymentID == id).FirstOrDefault();
            pt.type = type;
            db.SaveChanges();

            return true;
        }
    }
}