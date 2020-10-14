using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class ProductTypeRepository
    {
        static TokoBeDiaContainer db = new TokoBeDiaContainer();

        public static List<ProductType> getProductType()
        {
            return db.ProductTypes.ToList();
        }

        public static Boolean removeProductType(int productTypeID)
        {
            ProductType productType = db.ProductTypes.Where(x => x.productTypeID == productTypeID).FirstOrDefault();
            db.ProductTypes.Remove(productType);
            db.SaveChanges();

            return true;
        }

        public static Boolean insertProductType(string productTypeName, string productTypeDescription)
        {
            ProductType productType = ProductTypeFactory.CreateProductType(productTypeName, productTypeDescription);

            db.ProductTypes.Add(productType);
            db.SaveChanges();

            return true;
        }

        public static Boolean updateProductType(int productTypeID, string productTypeName, string productTypeDescription)
        {
            ProductType productType = db.ProductTypes.Where(x => x.productTypeID == productTypeID).FirstOrDefault();
            productType.productTypeName = productTypeName;
            productType.productTypeDescription = productTypeDescription;
            db.SaveChanges();

            return true;
        }

        public static ProductType checkProductType(int productTypeID)
        {
            ProductType productTypeX = (from productType in db.ProductTypes
                                    where productType.productTypeID == productTypeID
                                    select productType).FirstOrDefault();

            return productTypeX;
        }
    }
}