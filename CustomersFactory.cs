using System;
using System.Collections.Generic;

namespace Shops
{
    class CustomersFactory
    {
        Random numberGenerator = new Random();
        int departmentsCount = 7;
        private List<ShopListItem> GenerateShopListForCustomer()
        {
            const int maxPurchaseCount = 5;
            int customerPurchaseCount = numberGenerator.Next(2, maxPurchaseCount);
            List<ShopListItem> customerShopList = new List<ShopListItem>();
            for (int i = 0; i < customerPurchaseCount; i++)
            {
                customerShopList.Add(new ShopListItem(this.numberGenerator.Next(departmentsCount)));
            }
            return customerShopList;

        }

        public List<Customer> GenerateCustomers()
        {
            const int maxCustomersCount = 20;
            int customersCount = numberGenerator.Next(2, maxCustomersCount);
            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < customersCount; i++)
            {
                customers.Add(new Customer(GenerateShopListForCustomer()));
            }
            return customers;

        }

    }
}
