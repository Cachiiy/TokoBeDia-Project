using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class ProductRepository
    {
        static TokoBeDiaContainer db = new TokoBeDiaContainer();

        public static List<Product> getProducts()
        {
            return db.Products.ToList();
        }

        public static List<Product> getAllProduct()
        {
            List<Product> productList = db.Products.ToList<Product>();
            return productList;
        }

        public static Boolean removeProduct(int productID)
        {
            Product product = db.Products.Where(x => x.productID == productID).FirstOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();

            return true;
        }

        public static Boolean insertProduct(string productName, int productStock, int productPrice, int productTypeID)
        {
            Product product = ProductFactory.CreateProduct(productTypeID, productName, productPrice, productStock);

            db.Products.Add(product);
            db.SaveChanges();

            return true;
        }

        public static Boolean updateProduct(int productID, string productName, int productStock, int productPrice)
        {
            Product product = db.Products.Where(x => x.productID == productID).FirstOrDefault();
            product.productName = productName;
            product.productStock = productStock;
            product.productPrice = productPrice;
            db.SaveChanges();

            return true;
        }

        public static int getproductId(int productID)
        {
            int productId = (from x in db.Products where x.productID == productID select x.productID).FirstOrDefault();
            return productId;
        }


        public static Product checkStock(int productStock)
        {
            Product productX = (from product in db.Products
                                where product.productStock == productStock
                                select product).FirstOrDefault();
            return productX;
        }

        public static Product checkProduct(int productID)
        {
            Product productX = (from product in db.Products
                                where product.productID == productID
                                select product).FirstOrDefault();

            return productX;
        }

        public static Product checkProductType(int productTypeID)
        {
            Product productX = (from product in db.Products
                                where product.productTypeID == productTypeID
                                select product).FirstOrDefault();

            return productX;
        }


        /*punya andre*/
        public static bool checkAda(int i)
        {
            if (db.Products.Where(a => a.productID == i).FirstOrDefault() != null)
            {
                return true;
            }
            return false;
        }

        public static List<int> getRandProdID()
        {
            Random rand = new Random();
            List<int> List = new List<int>();
            int max = db.Products.Max(p => p.productID);
            int num = rand.Next(0, max);
            while (List.Count != 5)
            {
                while (List.Contains(num))
                {
                    num = rand.Next(0, max);
                    while (checkAda(num) == false)
                    {
                        num = rand.Next(0, max);
                    }
                }
                List.Add(num);
            }
            return List;
        }

        public static List<Product> getRandProd()
        {
            List<int> id = getRandProdID();
            List<Product> prod = new List<Product>();
            for (int i = 0; i < id.Count; i++)
            {
                int x = id[i];
                Product p = db.Products.Where(a => a.productID == x).FirstOrDefault();
                prod.Add(p);
            }
            return prod;
        }
        /*punya andre*/
    }

        



}