using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class Installment :ADebt
    {//рассрочка

        public int Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MinimumPayment { get; set; }
        public override decimal GetMinimumBalance()
        {
            return 0;
        }
        public override decimal GetMonthlyPayment()
        {
            return 0;
        }
        public override void AddMoney(decimal amount)
        {
            Balance += amount;
        }
        public override void WithdrawalMoney(decimal amount)
        {
            
        }

    }
}
