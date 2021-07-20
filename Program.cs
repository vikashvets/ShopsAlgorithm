using System.Collections.Generic;

namespace Shops
{
    class Program
    {
      
        static void Main(string[] args)
        {
            SimulateShopWork();
        }

        static void SimulateShopWork()
        {
            ShopConfiguration shopConfiguration = new ShopConfiguration();
            CustomersFactory customerFactory = new CustomersFactory();
            DepartmentsFactory departmentsFactory = new DepartmentsFactory();
            List<Customer> customers = customerFactory.GenerateCustomers();
            List<Department> departments = departmentsFactory.GenerateDepartments();
            Scheduler.InitTimer(customers, departments);
        }
    }
}
