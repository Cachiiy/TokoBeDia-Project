using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class PaymentTypeFactory
    {
        public static PaymentType createPaymentType(string type)
        {
            PaymentType pt = new PaymentType();
            pt.type = type;

            return pt;
        }
    }
}