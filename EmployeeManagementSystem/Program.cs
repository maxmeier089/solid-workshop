using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee alex = new Employee(152, "Alex", 60000.00);
            Employee lena = new Employee(983, "Lena", 28);
            Employee julia = new Employee(378, "Julia");
            Project project = new Project("BMW", 30000.00);

            alex.SetOvertime(7);
            lena.SetOvertime(83);
            julia.SetProject(project);

            Console.WriteLine();

            double result = alex.CalculatePay(EmployeeType.REGULAR);
            Console.WriteLine("Alex Payment this month is: " + result);

            result = lena.CalculatePay(EmployeeType.HOURED);
            Console.WriteLine("Lena Payment this month is: " + result);

            result = julia.CalculatePay(EmployeeType.COMMISSIONED);
            Console.WriteLine("Julia Payment this month is: " + result);

        }
    }
}
