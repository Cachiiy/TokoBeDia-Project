using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.Handler
{
    public class ItemAuthHandler
    {
        public static List<Product> getProducts()
        {
            return ProductRepository.getProducts();
        }

        public static Product checkProduct(int id)
        {
            return ProductRepository.checkProduct(id);
        }

        public static List<ProductType> getProductType()
        {
            return ProductTypeRepository.getProductType();
        }

        public static ProductType checkProductType(int id)
        {
            return ProductTypeRepository.checkProductType(id);
        }

        public static Product checkProductTypeOnProduct(int id)
        {
            return ProductRepository.checkProductType(id);
        }

        public static Role getRoleUser(int id)
        {
            return RoleRepository.getRoleUser(id);
        }

        public static User checkUser(string email, string password)
        {
            return UserRepository.checkUser(email, password);
        }


        public static List<User> getUser()
        {
            return UserRepository.getUser();
        }

        public static User checkExistUser(string userName)
        {
            return UserRepository.checkExistUser(userName);
        }

        public static User checkExistUserId(int userId)
        {
            return UserRepository.checkExistUserId(userId);
        }

        //start here -Andre
        public static PaymentType checkExistPaymentType(string type)
        {
            return PaymentTypeRepository.checkPaymentType(type);
        }

        public static List<PaymentType> getPaymentType()
        {
            return PaymentTypeRepository.getPaymentType();
        }

        public static PaymentType checkExistPaymentTypeId(int id)
        {
            return PaymentTypeRepository.checkPaymentTypeId(id);
        }

        public static List<Product> getRandProduct()
        {
            return ProductRepository.getRandProd();
        }


    }
}