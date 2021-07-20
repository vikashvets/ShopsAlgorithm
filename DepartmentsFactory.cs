using System.Collections.Generic;

namespace Shops
{
    class DepartmentsFactory
    {

        public List<Department> GenerateDepartments()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department(Departments.Bakery, 3, 1, 1));
            departments.Add(new Department(Departments.CannedStuff, 2, 1, 1));
            departments.Add(new Department(Departments.Confectionery, 1, 3, 1));
            departments.Add(new Department(Departments.Diary, 2, 1, 1));
            departments.Add(new Department(Departments.Fish, 2, 3, 1));
            departments.Add(new Department(Departments.Frozen, 1, 1, 1));
            departments.Add(new Department(Departments.Grocery, 3, 1, 1));
            departments.Add(new Department(Departments.Meat, 2, 3, 1));
            return departments;
        }

    }
}
