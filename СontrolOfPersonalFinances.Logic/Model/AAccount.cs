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

        public string BankType { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public abstract void AddMoney(decimal amount);
        public abstract void WithdrawalMoney(decimal amount);
        public abstract decimal GetMinimumBalance();
        public abstract decimal GetMonthlyPayment();
    }  
}


