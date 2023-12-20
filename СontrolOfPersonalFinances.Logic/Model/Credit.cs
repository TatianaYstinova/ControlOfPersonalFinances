using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class Credit:ADebt
    {
        public decimal MinimumPayment { get; set; }
        public decimal InterestRate { get; set; }
        public int Term { get; set; }
        public bool CashWithdrawalAllowed { get; set; }

        public override void AddMoney(decimal amount)
        {
            Balance += amount;
        }

        public override void WithdrawalMoney(decimal amount)
        {
            Balance -= amount;
        }

        public override decimal GetMinimumBalance()
        {
            return 0;
        }

        public override decimal GetMonthlyPayment()
        {
            return MonthlyPayment;
        }
    }
}
