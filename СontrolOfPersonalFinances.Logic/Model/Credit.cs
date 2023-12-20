using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class Credit:ADebt
    {
        public override decimal _minimumBalance { get; } = 0;
        public override decimal _monthlyPayment { get; } = 0;

        public decimal InterestRate { get; set; }
        public int Term { get; set; }

        public virtual void AddMoney(decimal amount)
        {
            Balance += amount;
        }
        public override void WithdrawalMoney(decimal amount)
        {
            Balance -= amount;
        }



    }
}
