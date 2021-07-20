using System.Collections.Generic;

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
            departmentCapasities.Add(new Department(Departments.Bakery, 3, 1, 1));
            departmentCapasities.Add(new Department(Departments.CannedStuff, 2, 1, 1));
            departmentCapasities.Add(new Department(Departments.Confectionery, 1, 3, 1));
            departmentCapasities.Add(new Department(Departments.Diary, 2, 1, 1));
            departmentCapasities.Add(new Department(Departments.Fish, 2, 3, 1));
            departmentCapasities.Add(new Department(Departments.Frozen, 1, 1, 1));
            departmentCapasities.Add(new Department(Departments.Grocery, 3, 1, 1));
            departmentCapasities.Add(new Department(Departments.Meat, 2, 3, 1));
            return departmentCapasities;
        }

    }
}
