using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class CartRepository
    {
        static TokoBeDiaContainer db = new TokoBeDiaContainer();

        public static Boolean newCart(int userId, int productID, int quantity)
        {
            Cart cart = CartFactory.insertCart(userId, productID, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();

            return true;
        }

        public static Cart checkProduct(int productID)
        {
            Cart cart = db.Carts.Where(x => x.productID == productID).FirstOrDefault();
            return cart;
        }


        public static List<Cart> getAll()
        {
            return db.Carts.ToList<Cart>();
        }

        public static Cart isProductExist(int productID)
        {
            Cart cart = (from x in db.Carts where x.productID.Equals(productID) select x).FirstOrDefault();
            return cart;
        }

        public static Boolean updateQuantity(int productID, int quantity)
        {
            Cart cart = (from x in db.Carts where x.productID.Equals(productID) select x).FirstOrDefault();
            cart.Quantity = quantity;
            db.SaveChanges();

            return true;
        }

        public static Boolean removeAll()
        {
            db.Carts.RemoveRange(getAll());
            db.SaveChanges();
            return true;
        }


        public static Boolean removeFromCart(int productID)
        {
            Cart cart = (from x in db.Carts where x.productID == productID select x).FirstOrDefault();
            db.Carts.Remove(cart);
            db.SaveChanges();

            return true;
        }




    }
}