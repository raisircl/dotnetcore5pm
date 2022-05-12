using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        Employee SaveEmployee(Employee employee);
        List<Employee> GetEmployees();
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);

    }
}
