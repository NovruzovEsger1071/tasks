/*using System;

interface IStudent
{
    string Name { get; set; }
    string Surname { get; set; }

    string GetFullName();
}

class Student : IStudent
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public string GetFullName()
    {
        return Name + " " + Surname;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "Esger";
        student.Surname = "Novruzov";

        Console.WriteLine(student.GetFullName());
    }
}*/








using System;

interface IBankAccount
{
    decimal Balance { get; set; }

    void Deposit(decimal amount);

    void Withdraw(decimal amount);
}

class BankAccount : IBankAccount
{
    public decimal Balance { get; set; }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine("Balans artırıldı: " + amount);
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("Pul çıxarıldı: " + amount);
        }
        else
        {
            Console.WriteLine("Balansda kifayət qədər vəsait yoxdur");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(1000);
        account.Withdraw(300);
        account.Withdraw(800);

        Console.WriteLine("Cari balans: " + account.Balance);
    }
}