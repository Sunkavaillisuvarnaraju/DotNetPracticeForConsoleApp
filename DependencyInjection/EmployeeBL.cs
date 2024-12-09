using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class EmployeeBL
    {
        public IEmployee _emp;

        public EmployeeBL(IEmployee emp)
        {
            _emp = emp;
        }
        public List<Employee> GetEmployeeData()
        {          
            return _emp.GetEmployeeDetails();
        }
    }
}
