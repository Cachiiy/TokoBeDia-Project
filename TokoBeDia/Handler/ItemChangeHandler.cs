using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Repository;

namespace TokoBeDia.Handler
{
    public class ItemChangeHandler
    {
        public static Boolean insertProduct(string productName, int productStock, int productPrice, int productTypeID)
        {
            if (ProductRepository.insertProduct(productName, productStock, productPrice, productTypeID))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Boolean insertProductType(String productTypeName, String productTypeDescription)
        {
            return ProductTypeRepository.insertProductType(productTypeName, productTypeDescription);
        }

        public static Boolean newUser(int roleID, string userName, string userEmail, string userPassword, string userGender, string userStatus)
        {
            return UserRepository.newUser(roleID, userName, userEmail, userPassword, userGender, userStatus);
        }
        public static Boolean submitProduct(int id, string productName, int productStock, int productPrice)
        {
            if (ProductRepository.updateProduct(id, productName, productStock, productPrice))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean removeProduct(int id)
        {
            return ProductRepository.removeProduct(id);
        }

        public static Boolean removeProductType(int id)
        {
            return ProductTypeRepository.removeProductType(id);
        }

        public static Boolean updateProductType(int productTypeID, string productTypeName, string productTypeDescription)
        {
            return ProductTypeRepository.updateProductType(productTypeID, productTypeName, productTypeDescription);
        }

        public static Boolean updateUser(int id, string userEmail, string userName, string userGender)
        {
            return UserRepository.updateUser(id, userEmail, userName, userGender);
        }

        public static Boolean updateUserA(int id, string role, string status)
        {
            return UserRepository.updateUserA(id, role, status);
        }

        public static Boolean updatePassword(int id, string newPassword)
        {
            return UserRepository.updatePassword(id, newPassword);
        }

        //andre
        public static Boolean newPaymentType(string type)
        {
            return PaymentTypeRepository.insertPaymentType(type);
        }

        public static Boolean removePaymentType(int id)
        {
            return PaymentTypeRepository.removePaymentType(id);
        }

        public static Boolean updatePaymentType(int id, string type)
        {
            if (PaymentTypeRepository.updatePaymentType(id, type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}