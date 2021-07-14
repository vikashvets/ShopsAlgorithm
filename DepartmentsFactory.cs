using System;
using System.Collections.Generic;
using System.Text;

namespace Shops
{
    class DepartmentsFactory
    {

        public List<Department> GenerateDepartments()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department(Departments.BAKERY, 3, 1, 1));
            departments.Add(new Department(Departments.CANNED_STUFF, 2, 1, 1));
            departments.Add(new Department(Departments.CONFECTIONERY, 1, 3, 1));
            departments.Add(new Department(Departments.DIARY, 2, 1, 1));
            departments.Add(new Department(Departments.FISH, 2, 3, 1));
            departments.Add(new Department(Departments.FROZEN, 1, 1, 1));
            departments.Add(new Department(Departments.GROCERY, 3, 1, 1));
            departments.Add(new Department(Departments.MEAT, 2, 3, 1));
            return departments;
        }

    }
}
