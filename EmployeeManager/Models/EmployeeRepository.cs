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
                new Employee(){Id=1001,Name="Gaurav Narula", Email="gaurav@sircltech.com",Department=Department.HR},
                new Employee(){Id=1002,Name="Vinod Kumar", Email="vkn@sircltech.com",Department=Department.SW},
                new Employee(){Id=1003,Name="Raju Singh", Email="rishi@sircltech.com",Department=Department.Sales},
                new Employee(){Id=1004,Name="Neelam", Email="neelam@sircltech.com",Department=Department.HW},
                new Employee(){Id=1005,Name="Vaibhav", Email="pandey@sircltech.com",Department=Department.SW},

            };

        }

        public Employee Delete(int Id)
        {
            Employee employee = employees.FirstOrDefault(e => e.Id == Id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
            return employee;

        }

        public Employee GetEmployee(int Id)
        {
            return employees.FirstOrDefault(eid => eid.Id == Id);
        }


        public List<Employee> GetEmployees()
        {
            return employees.ToList();
        }

        public Employee SaveEmployee(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
            return employee;

        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = employees.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;

        }
    }
}
