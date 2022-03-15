using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ ID =1,Name="anas",Email="anasamin22311",Departmet=Dept.HR},
                new Employee(){ ID =2,Name="Emo",Email="Emo1998",Departmet=Dept.IT},
                new Employee(){ ID =3,Name="Ahmed",Email="Right1999",Departmet=Dept.IT}
            };

        }
        public Employee Add(Employee employee)
        {
            employee.ID =_employeeList.Max(e => e.ID)+1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee= _employeeList.FirstOrDefault(e => e.ID == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
                return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
        public Employee getEmployee(int id)
        {

            return _employeeList.FirstOrDefault(e=>e.ID==id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.ID == employeeChanges.ID);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Departmet = employeeChanges.Departmet;
                employee.PhotoPath = employeeChanges.PhotoPath;
            }
            return employee;
        }
    }
}
