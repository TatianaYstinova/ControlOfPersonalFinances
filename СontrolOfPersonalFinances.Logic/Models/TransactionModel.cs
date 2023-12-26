using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using СontrolOfPersonalFinances.Logic.Enums;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class TransactionModel
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Summ { get; set; }
        public DateTime time { get; set; }
        public int AccountId {  get; set; }
        public int СategoriesId {  get; set; } 
        public TransactionType Type { get; set; }
        public bool IsApproved {  get; set; }
        public void CheckSufficientFunds(int ammount)
        {
            AccountModel accountModel = new AccountModel();

            if(ammount<= accountModel.Balance)
            {
                accountModel.Balance -= ammount;

            }
            else
            {
                return;
            }
           
        }

    }
}
