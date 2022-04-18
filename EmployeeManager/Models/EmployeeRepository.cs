using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee(){Id=1001,Name="Gaurav Narula", Email="gaurav@sircltech.com",Department="PHP"},
                new Employee(){Id=1002,Name="Vinod Kumar", Email="vkn@sircltech.com",Department=".Net"},
                new Employee(){Id=1003,Name="Raju Singh", Email="rishi@sircltech.com",Department=".Net"},
                new Employee(){Id=1004,Name="Neelam", Email="neelam@sircltech.com",Department="PHP"},
                new Employee(){Id=1005,Name="Vaibhav", Email="pandey@sircltech.com",Department="Android"},

            };

        }
        public Employee GetEmployee(int Id)
        {
            return employees.FirstOrDefault(eid => eid.Id == Id);
        }


        public List<Employee> GetEmployees()
        {
            return employees.ToList();
        }

        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
