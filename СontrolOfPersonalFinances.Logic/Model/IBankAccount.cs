using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public interface IBankAccount
    {
        public decimal Balance {  get; set; }
        public void AddMoney(decimal amount);
        public void WithdrawalMoney(decimal amount);
        public decimal GetMinimumBalance();
        public decimal GetMonthlyPayment();
        public string  AccountName {  get; set; }

    }
}
