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
            while (customers.Any(customer => customer.shopList.Any(shopListItem => !shopListItem.isBuyed)))
            {
                Console.WriteLine("New iteration");
                CheckForAction(customers, departments);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Results");
        }


        public static void UpdateResources(Customer customer, ShopListItem availibleItem, Department selectedDepartment, int servingTime)
        {
            Thread.Sleep(servingTime * 1000);
            availibleItem.isBuyed = true;
            selectedDepartment.availibleSlotsCount += 1;
            customer.isServing = false;
            customer.spendedTime += servingTime;
        }

            public static void CheckForAction(List<Customer> customers, List<Department> departments)
        {
            foreach(Customer customer in customers)
            {
                if (!customer.IsServed() && !customer.isServing)
                {
                    ShopListItem availibleItem = customer.shopList
                        .Find(item => !item.isBuyed && departments
                        .Any(department => (int) department.department == item.itemDepartment && !department.IsBusy()));
                    if(availibleItem != null)
                    {
                        Department selectedDepartment = departments.Find(department => (int) department.department == availibleItem.itemDepartment);
                        selectedDepartment.availibleSlotsCount -= 1;
                        customer.isServing = true;
                        int servingTime = selectedDepartment.secondsPerCustomer + selectedDepartment.secondsForAdditionalPurchase * customer.shopList.Count(item => item.itemDepartment == (int)selectedDepartment.department);
                        var t = Task.Run(() => UpdateResources(customer, availibleItem, selectedDepartment, servingTime));

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
