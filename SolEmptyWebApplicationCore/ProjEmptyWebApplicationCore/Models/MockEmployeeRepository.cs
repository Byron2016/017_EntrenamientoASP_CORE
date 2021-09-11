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
                new Employee(){Id = 1, Name="N1", Department="HR", Email="mary@yahoo.com"},
                new Employee(){Id = 2, Name="N2", Department="IT", Email="jphn@yahoo.com"},
                new Employee(){Id = 3, Name="N3", Department="IT", Email="sam@yahoo.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            // throw new NotImplementedException();
            return _employeeList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
