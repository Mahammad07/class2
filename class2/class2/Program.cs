using System;

namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Abdullah";
            employee.Surname = "Dasdemirov";
            employee.Position = "Bagban";
            employee.DailySalary = 10;
            employee.MonthSalary(employee.Name, employee.Surname, employee.Position, employee.DailySalary);
        }
    }


    class Employee
    {
        public string Name;
            public string Surname;
        public string Position;
        public int DailySalary;

        public void MonthSalary(string name,string surname,string position,int dailySalary)
        {
            Console.WriteLine($"{name} {surname} {position} {dailySalary*30}");
        }
    }

       

}
