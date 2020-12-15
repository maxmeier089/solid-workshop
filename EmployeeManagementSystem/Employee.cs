using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Employee
    {

        private int id;
        private String name;
        private double salary;
        private int overtime;
        private Project project;


        public Employee(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public Employee(int id, String name, int overtime)
        {
            this.id = id;
            this.name = name;
            this.overtime = overtime;
        }


        public Employee(int id, String name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }


        public double CalculatePay(EmployeeType employeeType)
        {
            switch (employeeType)
            {
                case EmployeeType.REGULAR: return salary / 12 + overtime * 50;
                case EmployeeType.HOURED: return overtime * 90;
                case EmployeeType.COMMISSIONED: return project.GetAsset() * 0.18;
                default: throw new Exception("Unknown Employee Type!");
            }
        }


        public String ReportHours(EmployeeType employeeType)
        {
            switch (employeeType)
            {
                case EmployeeType.REGULAR:
                    return "Employee " + this + " has " + CalculateRegularHours() + overtime + " hours per Week";
                case EmployeeType.HOURED:
                    return "Freelancer " + this + " has " + overtime + " hours per Week";
                case EmployeeType.COMMISSIONED:
                    return "Commissioned, Working hours are not relevant!";
                default:
                    throw new Exception("Unknown Employee Type!");
            }
        }


        public void PrintReport()
        {
            Console.WriteLine("Printing the Employee " + this);
        }


        public void SaveEmployee()
        {
            Console.WriteLine("Saving Employee to database...");
        }


        private double CalculateRegularHours()
        {
            return 40.5;
        }


        public void SetOvertime(int overtime)
        {
            this.overtime = overtime;
        }

        public void SetProject(Project project)
        {
            this.project = project;
        }
    }
}
