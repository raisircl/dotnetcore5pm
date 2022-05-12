using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManager.Models
{
    public class EmployeeRepoSqlServer : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepoSqlServer(AppDbContext context)
        {
            this.context = context;
        }

        public Employee Delete(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            if(employee!=null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            return context.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }

        public Employee SaveEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
