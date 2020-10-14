using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Handler;

namespace TokoBeDia.Controller
{
    public class CartController
    {
        public static void addToCart(int userId, int productID, int quantity)
        {
            Product product = CartHandler.getProductById(productID);
            Cart cart = CartHandler.isProductExistInCart(product.productID);
            if (cart == null)
            {
                CartHandler.addToCart(userId, productID, quantity);
            }
            else
            {
                CartHandler.updateCartProductQuantity(product.productID, quantity);
            }
        }

       

       public static int doTransaction(int userID, DateTime date,int paymentTypeID)
        {
            List<Cart> cartlist2 = CartHandler.getCart();
            foreach (Cart cart in cartlist2)
            {
                if (cart.Quantity == 0)
                {
                    CartHandler.removeFromCart(cart.productID);
                }
            }
            int transactionID = CartHandler.insertTransaction(userID, date, paymentTypeID);
            CartHandler.removeAllFromCart();

            return transactionID;
        }

        public static int paymentTypeID(string type)
        {
            int id = CartHandler.getPaymentID(type);
            return id;
        }

        public static void removeCart(int productID)
        {
            List<Cart> cartlist2 = CartHandler.getCart();
            foreach (Cart cart in cartlist2)
            if (cart.Quantity == 0)
            {
                    CartHandler.removeFromCart(productID);
            }
        }




        public static Boolean removeItem(int productID)
        {
            CartHandler.removeFromCart(productID);
            return true;
        }

        public static void updateQuantity(int productID, int quantity)
        {
            Product product = CartHandler.getProductById(productID);
            CartHandler.updateCartProductQuantity(product.productID, quantity);
        }

        public static Boolean isProductExist(int productID)
        {
            Product product = CartHandler.getProductById(productID);
            if (product == null)
            {
                return false;
            }
            return true;
        }

        public static Boolean isTypeExist(int TypeID)
        {
            PaymentType pt = CartHandler.getType(TypeID);
            if (pt == null)
            {
                return false;
            }
            return true;
        }

        public static Boolean checkstock(int productID)
        {
            Product product = CartHandler.getProductById(productID);
            
            if (product.productStock == 0)
            {
                return false;
            }
            return true;
        }
                 

        public static List<Cart> getAllCartItem()
        {
            return CartHandler.getCart();
        }

        public static List<Product> getProduct()
        {
            return ItemAuthHandler.getProducts();
        }

        public static Product getProdStocks(int id)
        {
            return CartHandler.getProductById(id);
        }

        public static List<PaymentType> getptList()
        {
            return CartHandler.getpt();
        }
    }
}