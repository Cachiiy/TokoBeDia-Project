using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.Handler
{
    public class CartHandler
    {
        public static void addToCart(int userId, int productID, int quantity)
        {
            CartRepository.newCart(userId, productID, quantity);
        }

        public static Product getProductById(int productID)
        {
            return ProductRepository.checkProduct(productID);
        }

        public static void removeAllFromCart()
        {
            CartRepository.removeAll();
        } // buat checkout

        public static int insertTransaction(int userID, DateTime date, int paymentTypeID)
        {
            DateTime currDate = DateTime.Now;
            int User = userID;

            int transactionID = HeaderTransactionRepository.newTransaction(userID, currDate, paymentTypeID);

            List<Cart> cartlist = getCart();
            foreach (Cart cart in cartlist)
            {
                int productID = ProductRepository.getproductId(cart.productID);

                DetailTransactionRepository.newTransactionDetail(transactionID, productID, cart.Quantity);
            }
            return transactionID;
        }

        public static int getPaymentID(string type)
        {
            return PaymentTypeRepository.getPaymentTypeID(type);
        }

        public static PaymentType getType(int typeID)
        {
            return PaymentTypeRepository.checkPaymentTypeId(typeID);
        }

        public static Product getProductStock(int productID)
        {
            return ProductRepository.checkProduct(productID);
        }

        public static Cart isProductExistInCart(int productID)
        {
            return CartRepository.isProductExist(productID);
        }

        public static void updateCartProductQuantity(int productID, int quantity)
        {
            CartRepository.updateQuantity(productID, quantity);
        }

        public static List<Cart> getCart()
        {
            return CartRepository.getAll();
        }

       
        public static void removeFromCart(int productID)
        {
            CartRepository.removeFromCart(productID);
        }

        public static List<PaymentType> getpt()
        {
            return PaymentTypeRepository.getPaymentType();
        }

    }
}