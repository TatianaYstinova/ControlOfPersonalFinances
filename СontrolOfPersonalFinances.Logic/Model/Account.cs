using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class Account : AAccount
    {
        public override decimal _minimumBalance { get; } = 0;
        public override decimal _monthlyPayment { get; } = 0;
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Currency { get; set; }
        public override void WithdrawalMoney(decimal amount)
        {
            Balance -= amount;
        }
    }
}
