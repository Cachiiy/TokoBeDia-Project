using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class CartFactory
    {
        public static Cart insertCart(int userId, int productId, int quantity)
        {
            Cart cart = new Cart();
            cart.userID = userId;
            cart.productID = productId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}