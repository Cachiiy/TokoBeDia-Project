using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handler;
using TokoBeDia.Model;

namespace TokoBeDia.Controller
{
    public class CrudController
    {
        public static Boolean insertProduct(string productName, int productStock, int productPrice, int productTypeID)
        {
            ItemChangeHandler.insertProduct(productName, productStock, productPrice, productTypeID);
            return true;
        }

        public static Boolean insertProductType(string productTypeName, string productTypeDescription)
        {
            ItemChangeHandler.insertProductType(productTypeName, productTypeDescription);
            return true;
        }

        public static Boolean newUser(int roleID, string userName, string userEmail, string userPassword, string userGender, string userStatus)
        {
            ItemChangeHandler.newUser(roleID, userName, userEmail, userPassword, userGender, userStatus);
            return true;
        }

        public static Boolean updatePassword(int id, string newPassword)
        {
            ItemChangeHandler.updatePassword(id, newPassword);
            return true;
        }

        public static Boolean submitProduct(int id, string productName, int productStock, int productPrice)
        {
            ItemChangeHandler.submitProduct(id, productName, productStock, productPrice);
            return true;
        }

        public static Boolean updateProductType(int id, string productTypeName, string productTypeDescription)
        {
            ItemChangeHandler.updateProductType(id, productTypeName, productTypeDescription);
            return true;
        }

        public static Boolean updateUser(int id, string userEmail, string userName, string userGender)
        {
            ItemChangeHandler.updateUser(id, userEmail, userName, userGender);
            return true;
        }

        public static Boolean removeProduct(int id)
        {
            ItemChangeHandler.removeProduct(id);
            return true;
        }

        public static List<Product> getProducts()
        {
            return ItemAuthHandler.getProducts();
        }

        public static List<ProductType> getProductType()
        {
            return ItemAuthHandler.getProductType();
        }

        public static Boolean removeProductType(int id)
        {
            return ItemChangeHandler.removeProductType(id);
        }

        public static List<User> getUser()
        {
            return ItemAuthHandler.getUser();
        }

        public static Boolean updateUserA(int id, string role, string status)
        {
            return ItemChangeHandler.updateUserA(id, role, status);
        }

        //andre
        public static Boolean newPaymentType(string type)
        {
            ItemChangeHandler.newPaymentType(type);
            return true;
        }

        public static Boolean removePaymentType(int id)
        {
            ItemChangeHandler.removePaymentType(id);
            return true;
        }

        public static List<PaymentType> getPaymentType()
        {
            return ItemAuthHandler.getPaymentType();
        }

        public static Boolean updatePaymentType(int id, string type)
        {
            ItemChangeHandler.updatePaymentType(id, type);
            return true;
        }
    }
}