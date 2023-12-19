using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public interface IAccount
    {
        public decimal Balance {  get; set; }
        public void Addendum(decimal amount);
        public void Withdrawal(decimal amount);
         public decimal MinimumAmount { get; }
         public int MonthlyPayment {  get; set; }

    }
}
