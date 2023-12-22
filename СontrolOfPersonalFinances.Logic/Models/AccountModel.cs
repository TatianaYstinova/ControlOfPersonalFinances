using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СontrolOfPersonalFinances.Logic.Enums;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class AccountModel : IBankAccount
    {
      
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Currency { get; set; }
        public AccountType type { get; set; }
        public string Id {  get; set; }
        public string Comment { get; set; }
    }
}
