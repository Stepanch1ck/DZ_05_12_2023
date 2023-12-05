using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace TumakovLab_13
{
    public enum AccountType
    {
        Current,
        Saving
    }
    internal class BankAccount
    {
        public static int AccountID = 1;
        public int AccountNumber { get; private set; }
        protected decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Значение баланса не может быть отрицательным");
                }

                _balance = value;
                _transactions.Add(new BankTransaction(value));
            }
        }

        public AccountType AccountType { get; }

        public string Holder { get; set; }

        public List<BankTransaction> _transactions = new List<BankTransaction>();

        public BankAccount()
        {
            AccountNumber = AccountID;
            _transactions = new List<BankTransaction>();
            AccountID++;
        }

        public BankAccount(decimal balance)
        {
            AccountNumber = AccountID;
            Balance = balance;
            _transactions = new List<BankTransaction>();
            AccountID++;
        }

        public BankAccount(AccountType accountType)
        {
            AccountNumber = AccountID;
            AccountType = accountType;
            _transactions = new List<BankTransaction>();
            AccountID++;
        }

        public BankAccount(decimal balance, AccountType accountType, string holder)
        {
            AccountNumber = AccountID;
            Balance = balance;
            AccountType = accountType;
            Holder = holder;
            _transactions = new List<BankTransaction>();
            AccountID++;
        }
        

        

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Сумма снятия превышает баланс");
            }

            Balance -= amount;
            _transactions.Add(new BankTransaction(-amount));
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new BankTransaction(amount));
        }

        public void Transfer(BankAccount otherAccount, decimal amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Сумма перевода превышает баланс");
            }

            Withdraw(amount);
            otherAccount.Deposit(amount);
        }

        public override string ToString()
        {
            return $"Номер счета: {AccountNumber}, баланс: {Balance}, тип счета: {AccountType}, держатель: {Holder}";
        }

        public void PrintAccount()
        {
            Console.WriteLine(this.ToString());
        }

        public List<BankTransaction> Transactions
        {
            get { return _transactions; }
        }
        public void Dispose()
        {
            string filename = $"{AccountNumber}.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (BankTransaction transaction in _transactions)
                {
                    writer.WriteLine(transaction.ToString());
                }
            }
            GC.SuppressFinalize(this);
        }
        public BankTransaction this[int index]
        {
            get
            {
                if (index >= 0 && index < _transactions.Count)
                {
                    return _transactions[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
        }


    }
}

