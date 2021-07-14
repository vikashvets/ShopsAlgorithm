using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Shops
{
    class Scheduler
    { 
        public static void InitTimer (List<Customer> customers, List<Department> departments)
        {
            /*var t = Task.Run(() => {
                 Console.WriteLine("t1 has been launched");
                 while (customers.Any(customer => customer.shopList.Any(shopListItem => !shopListItem.isBuyed)))
                 {
                     CheckForAction(customers, departments);
                     Thread.Sleep(1000);
                     Console.WriteLine("New iteration");
                 }
             });
             t.Wait();*/
            while (customers.Any(customer => customer.shopList.Any(shopListItem => !shopListItem.isBuyed)))
            {
                CheckForAction(customers, departments);
                Thread.Sleep(1000);
                Console.WriteLine("New iteration");
            }
            Console.WriteLine("Results");
        }


        public static void UpdateResources(Customer customer, ShopListItem availibleItem, Department selectedDepartment, int servingTime)
        {
            availibleItem.isBuyed = true;
            selectedDepartment.availibleSlotsCount += 1;
            customer.isServing = false;
            customer.spendedTime += servingTime;
        }

            public static void CheckForAction(List<Customer> customers, List<Department> departments)
        {
            foreach(Customer customer in customers)
            {
                if (!customer.isServed() && !customer.isServing)
                {
                    ShopListItem availibleItem = customer.shopList
                        .Find(item => !item.isBuyed && departments
                        .Any(department => (int) department.department == item.itemDepartment && !department.isBusy));
                    if(availibleItem != null)
                    {
                        Department selectedDepartment = departments.Find(department => (int) department.department == availibleItem.itemDepartment);
                        selectedDepartment.availibleSlotsCount -= 1;
                        customer.isServing = true;
                        int servingTime = selectedDepartment.secondsPerCustomer + selectedDepartment.secondsForAdditionalPurchase * customer.shopList.Count(item => item.itemDepartment == (int)selectedDepartment.department);
                        Thread.Sleep(servingTime * 1000);
                        UpdateResources(customer, availibleItem, selectedDepartment, servingTime);
                    }
                    else
                    {
                        customer.waitingTime += 1;
                    }
                }
            }
        }
    }
}
