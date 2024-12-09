using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{

    public interface IEmployee
    {
        public List<Employee> GetEmployeeDetails();
    }

    public class EmployeeDAL : IEmployee 
    {
        public List<Employee> GetEmployeeDetails()
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee() {EmpId = 101, Name ="Johny", Salary = 10000},
                new Employee() {EmpId = 102, Name = "Dani", Salary = 20000},
                new Employee() {EmpId = 103, Name = "Mia", Salary = 30000}
            };
            return employees;
        }
    }
    public class EmployeeDALUnitTesting : IEmployee
    {
        public List<Employee> GetEmployeeDetails()
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee() {EmpId = 101, Name ="Johny", Salary = 10000},
                new Employee() {EmpId = 102, Name = "Dani", Salary = 20000},
                new Employee() {EmpId = 103, Name = "Mia", Salary = 30000}
            };
            return employees;
        }
    }
}
