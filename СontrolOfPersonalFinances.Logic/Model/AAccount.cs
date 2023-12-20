using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public abstract class AAccount : IBankAccount
    {//счет
        public abstract decimal _minimumBalance { get; }
        public abstract decimal _monthlyPayment {  get; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Currency { get; set; }

        public void  AddMoney(decimal amount)
        {
            if (amount >= GetMonthlyPayment())
            {
                Balance += amount;
            }
            else
            {
                // Oшибка!!
            }   
        }
        
        public abstract void WithdrawalMoney(decimal amount);
        public  decimal GetMinimumBalance()
        {
            return _minimumBalance;
        }
        public decimal GetMonthlyPayment()
        {
            return _monthlyPayment;
        }
    }  
}


