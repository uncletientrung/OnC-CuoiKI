// See https://aka.ms/new-console-template for more information

using System;
// CÂU 2
public class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; } // Lương cơ bản
    public Employee(string name, double baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }
    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }
}

public class Contractor : Employee
{
    public int HoursWorked { get; set; } // Số giờ làm việc
    public double HourlyRate { get; set; } // Mức lương theo giờ

    public Contractor(string name, int hoursWorked, double hourlyRate)
        : base(name, 0) // BaseSalary = 0, vì lương tính theo giờ
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }

    public override double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }
}
public class SavingAccount
{
    private double Balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && Balance-amount >= 150)
        {
            Balance -= amount;
        }
    }

    public double GetBalance()
    {
        return Balance;
    }
}

class Student
{
    public string Name { get; set; }
    public double GPA { get; set; }
    public void Introduce()
    {
        Console.WriteLine($"Tôi là {Name} và {GPA}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Câu 2
        //Employee employee = new Employee("Alice", 50000);
        //Contractor contractor = new Contractor("David", 120, 50);
        //Console.WriteLine(employee.Name + " - Tổng thu nhập: " + employee.CalculateSalary());
        //Console.WriteLine(contractor.Name + " - Tổng thu nhập: " + contractor.CalculateSalary());

        // Câu 2.2
        //int number = 1;
        //while (number <= 10)
        //{
        //    if ((number + 1) % 2 == 0)
        //        Console.WriteLine("Số loại 1: " + number);
        //    else
        //        Console.WriteLine("Số loại   2: " + number);

        //    number++;
        //}

        // Câu 3.1
        //SavingAccount account = new SavingAccount();
        //account.Deposit(250);
        //account.Withdraw(150);
        //Console.WriteLine("Số dư tài khoản: " + account.GetBalance());

        // Câu 3.2
        //Student std= new Student();
        //std.Name = "Trung"; std.GPA = 3.9;
        //std.Introduce();

        // Câu 4

    }
}
