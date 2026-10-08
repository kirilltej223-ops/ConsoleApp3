using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.fio = "Тей Кирилл Денисович";
            emp.salary = 63500;

            emp.Show();

            int annualSalary = emp.CalculateAnnualSalary();

            Console.WriteLine($"Годовой размер зарплаты сотрудника: {annualSalary} руб.");

            Console.ReadKey();
        }
    }

    class Employee
    {
        public string fio;
        public int salary;

        public void Show()
        {
            Console.WriteLine($"Служащий: ФИО = {fio}, Зарплата = {salary} руб.");
        }

        public int CalculateAnnualSalary()
        {
            int result = salary * 12;
            return result;
        }
    }
}
