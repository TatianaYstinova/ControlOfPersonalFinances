using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class Installment :ADebt
    {//рассрочка
        public override decimal _minimumBalance { get; }
        public override decimal _monthlyPayment { get; } 
        public int Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MinimumPayment { get; set; }
        public virtual decimal GetMinimumBalance()
        {
            return 0;
        }
        public virtual decimal GetMonthlyPayment()
        {
            return _monthlyPayment;
        }
        public virtual void AddMoney(decimal amount)
        {
            Balance += amount;
        }
        public override void WithdrawalMoney(decimal amount)
        {
            
        }

    }
}
