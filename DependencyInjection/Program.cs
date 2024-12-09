namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeBL emp = new EmployeeBL(new EmployeeDAL());
            EmployeeBL emp1 = new EmployeeBL(new EmployeeDALUnitTesting());
            List<Employee> empl = emp1.GetEmployeeData();
            foreach (Employee e in empl)
            {
                Console.WriteLine($"Employee Id :{e.EmpId}\t Employee Name: {e.Name}\t Employee Salary: {e.Salary}");
            }
            Console.ReadLine();
        }
    }
}
