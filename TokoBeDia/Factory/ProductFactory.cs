using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class ProductFactory
    {
        public static Product CreateProduct(
            int productTypeID,
            string productName,
            int productPrice,
            int productStock
            )
        {
            Product product = new Product();

            product.productTypeID = productTypeID;
            product.productName = productName;
            product.productPrice = productPrice;
            product.productStock = productStock;

            return product;
        }
    }
}