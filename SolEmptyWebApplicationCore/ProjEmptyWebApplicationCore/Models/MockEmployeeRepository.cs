using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>() 
            { 
                new Employee(){Id = 1, Name="N1", Department=Dept.HR, Email="mary@yahoo.com"},
                new Employee(){Id = 2, Name="N2", Department=Dept.IT, Email="jphn@yahoo.com"},
                new Employee(){Id = 3, Name="N3", Department=Dept.IT, Email="sam@yahoo.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if(employee!= null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            // throw new NotImplementedException();
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
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
