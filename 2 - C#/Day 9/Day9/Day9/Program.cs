namespace Day9
{

    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository.EmployeeFilter departmentFilter = e => e.DeptId == 2;
            List<Employee> dept2Employees = EmployeeRepository.GetFilteredEmployees(departmentFilter);


            Console.WriteLine("dept 2 Employees:");

            foreach (var employee in dept2Employees)
                Console.WriteLine($"{employee.Name}, {employee.DeptId}, ${employee.Salary}");



            EmployeeRepository.EmployeeFilter salaryFilter = e => e.Salary > 3000;
            List<Employee> highSalaryEmployees = EmployeeRepository.GetFilteredEmployees(salaryFilter);


            Console.WriteLine("\nEmployees with Salary > 3000:");

            foreach (var employee in highSalaryEmployees)
                Console.WriteLine($"{employee.Name}, {employee.DeptId}, ${employee.Salary}");

        }
    }
}
