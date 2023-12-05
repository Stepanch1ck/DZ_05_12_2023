using System;

namespace TumakovLab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 13 упражнения 1-2");
            BankAccount account = new BankAccount(1000, AccountType.Current, "OLEG");
            account.Deposit(100);
            account.Withdraw(50);

            BankTransaction transaction = account[0];
            Console.WriteLine(transaction.Amount);



            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
            Console.WriteLine("Лабораторная работа 13 домашенее задание 1");

            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Лабораторная работа 13 домашенее задание 1");
            Building building = new Building(100, 10, 100, 10);
            Console.WriteLine(building);
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Лабораторная работа 13 домашенее задание 2");
            Buildings buildings = new Buildings();

            buildings[0].Height = 100;
            buildings[1].Height = 200;
            buildings[2].Height = 300;

            Console.WriteLine(buildings[0].Height);
            Console.WriteLine(buildings[1].Height);
            Console.WriteLine(buildings[2].Height);
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
        }
    }
}
