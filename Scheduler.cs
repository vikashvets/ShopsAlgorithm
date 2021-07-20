using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Shops
{
    static class Scheduler
    { 
        public static void InitTimer (List<Customer> customers, List<Department> departments)
        {
            while (customers.Any(customer => customer.ShopList.Any(shopListItem => !shopListItem.isBuyed)))
            {
                Console.WriteLine("New iteration");
                CheckForAction(customers, departments);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Results");
        }


        private static void UpdateResources(Customer customer, ShopListItem availableItem, Department selectedDepartment, int servingTime)
        {
            Thread.Sleep(servingTime * 1000);
            availableItem.isBuyed = true;
            selectedDepartment.AvailableSlotsCount += 1;
            customer.IsServing = false;
            customer.SpendedTime += servingTime;
        }

        private static void CheckForAction(List<Customer> customers, List<Department> departments)
        {
            foreach(Customer customer in customers)
            {
                if (!customer.IsServed() && !customer.IsServing)
                {
                    ShopListItem availableItem = customer.ShopList
                        .Find(item => !item.isBuyed && departments
                        .Any(department => (int) department.department == item.itemDepartment && !department.IsBusy()));
                    if(availableItem != null)
                    {
                        Department selectedDepartment = departments.Find(department => (int) department.department == availableItem.itemDepartment);
                        selectedDepartment.AvailableSlotsCount -= 1;
                        customer.IsServing = true;
                        int servingTime = selectedDepartment.SecondsPerCustomer + selectedDepartment.SecondsForAdditionalPurchase * (customer.ShopList.Count(item => item.itemDepartment == (int)selectedDepartment.department) - 1);
                        var t = Task.Run(() => UpdateResources(customer, availableItem, selectedDepartment, servingTime));

                    }
                    else
                    {
                        customer.WaitingTime += 1;
                    }
                }
            }
        }
    }
}
