using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id= 1, Name="Mona",Department="HR", Email="Mohan@gmail.com" },
                new Employee() { Id= 2, Name="Mona1",Department="HR1", Email="Mohan1@gmail.com" },
                new Employee() { Id= 3, Name="Mona3",Department="HR3", Email="Mohan2@gmail.com" }

            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
            
        }

        
        
    }
}
