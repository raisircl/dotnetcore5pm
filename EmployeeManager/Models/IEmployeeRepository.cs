using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        void SaveEmployee(Employee employee);
        List<Employee> GetEmployees();

    }
}
