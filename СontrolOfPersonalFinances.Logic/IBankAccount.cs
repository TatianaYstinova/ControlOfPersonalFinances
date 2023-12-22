using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СontrolOfPersonalFinances.Logic.Enums;

namespace СontrolOfPersonalFinances.Logic
{
    public interface IBankAccount
    {
        public decimal _minimumBalance { get; }
        public decimal _monthlyPayment { get; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Currency { get; set; }
        public AccountType type { get; set; }
    }
}
