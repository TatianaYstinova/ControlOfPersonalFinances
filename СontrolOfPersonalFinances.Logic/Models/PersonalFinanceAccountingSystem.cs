using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{

    public class PersonalFinanceAccountingSystem 
    {
        public List<IBankAccount> accounts {  get; set; }
        public List<IBankAccount> сredit { get; set; }
        public List<IBankAccount> installment {  get; set; }
        public PersonalFinanceAccountingSystem()
        {
            accounts = new List<IBankAccount>();
            сredit = new List<IBankAccount>();
            installment = new List<IBankAccount>();
        }
    }
}
