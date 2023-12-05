using System;
using TumakovLab_13;

namespace TumakovLab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 14 упражнение 1");
            BankAccount account = new BankAccount(1000, AccountType.Current, "OLEG");
            account.Deposit(1000);
            account.DumpToScreen();
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
        }
    }
}
