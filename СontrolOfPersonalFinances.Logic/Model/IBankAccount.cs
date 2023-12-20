using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public interface IBankAccount
    {
        public decimal _minimumBalance { get; }
        public decimal _monthlyPayment { get; }
        public decimal Balance {  get; set; }
        public string  AccountNumber {  get; set; }
        public string BankName { get; set; }
        public string Currency { get; set; }
        public void AddMoney(decimal amount);
        public void WithdrawalMoney(decimal amount);
        public decimal GetMinimumBalance();// const
        public decimal GetMonthlyPayment();// ежемесячный плтеж //const
    }
}
