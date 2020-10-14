using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class ProductTypeFactory
    {
        public static ProductType CreateProductType(
            string productTypeName,
            string productTypeDescription)
        {
            ProductType productType = new ProductType();

            productType.productTypeName = productTypeName;
            productType.productTypeDescription = productTypeDescription;

            return productType;
        }
    }
}