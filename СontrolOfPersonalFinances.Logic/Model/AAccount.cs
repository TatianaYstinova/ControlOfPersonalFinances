using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public abstract class AAccount : IAccount
    {//счет
        public abstract string TypeBank { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public abstract decimal MinimumAmount { get; }// мин.сумма
        public int MonthlyPayment { get; set; }// мес.платеж
        public  void Addendum(decimal amount)//добавление денег
        {
            Balance += amount;
        }
        public void Withdrawal(decimal amount)// снять денег
        {
            if (Balance > amount)
            {
                Balance -= amount;


            }
        }
        public AAccount(string typeBank, string name, decimal balance,  int monthlyPayment)
        {
            TypeBank = typeBank;
            Name = name;
            Balance = balance;
            MonthlyPayment = monthlyPayment;
        }
    }
}
