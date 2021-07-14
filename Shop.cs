using System;
using System.Collections.Generic;
using System.Text;

namespace Shops
{
    class ShopConfiguration
    {
        List<Department> departmentsCapacity;
        int storeCapacity;
        public ShopConfiguration()
        {
            this.storeCapacity = 20;
            this.departmentsCapacity = generateDepartmentCapasity();
        }

        private List<Department> generateDepartmentCapasity()
        {
            List<Department> departmentCapasities = new List<Department>();
            departmentCapasities.Add(new Department(Departments.BAKERY, 3, 1, 1));
            departmentCapasities.Add(new Department(Departments.CANNED_STUFF, 2, 1, 1));
            departmentCapasities.Add(new Department(Departments.CONFECTIONERY, 1, 3, 1));
            departmentCapasities.Add(new Department(Departments.DIARY, 2, 1, 1));
            departmentCapasities.Add(new Department(Departments.FISH, 2, 3, 1));
            departmentCapasities.Add(new Department(Departments.FROZEN, 1, 1, 1));
            departmentCapasities.Add(new Department(Departments.GROCERY, 3, 1, 1));
            departmentCapasities.Add(new Department(Departments.MEAT, 2, 3, 1));
            return departmentCapasities;
        }

    }
}
