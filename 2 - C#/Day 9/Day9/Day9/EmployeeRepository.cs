namespace Day9
{
    // Static repository class
    public static class EmployeeRepository
    {

        // Static list of employees
        private static List<Employee> employees = new List<Employee>(){
            new Employee {Id = 1, Name = "Ahmed", Age = 25, Salary = 2234, DeptId = 1},
            new Employee {Id = 2, Name = "Ali", Age = 28, Salary = 1234, DeptId = 2},
            new Employee {Id = 3, Name = "Omar", Age = 22, Salary = 3234, DeptId = 3},
            new Employee {Id = 4, Name = "Sara", Age = 26, Salary = 8234, DeptId = 1},
            new Employee {Id = 5, Name = "Eman", Age = 21, Salary = 2234, DeptId = 2},
            new Employee {Id = 6, Name = "Nada", Age = 24, Salary = 1234, DeptId = 1},
        };


        // Delegate to filter employees
        public delegate bool EmployeeFilter(Employee employee);

        // Method to get filtered employees
        public static List<Employee> GetFilteredEmployees(EmployeeFilter filter)
        {
            return employees.Where(e => filter(e)).ToList();
        }
    }
}
