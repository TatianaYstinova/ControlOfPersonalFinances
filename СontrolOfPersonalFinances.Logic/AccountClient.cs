using System;
using System.Collections.Generic;
using System.Windows.Documents;
using СontrolOfPersonalFinances.Logic.Model;

namespace СontrolOfPersonalFinances.Logic
{
    public class AccountClient
    {
        public List<Account> _accounts;// cчет
        public List<ADebt> _debts;//долгов
       

        public AccountClient()
        {
            _accounts = new List<Account>();
            _debts = new List<ADebt>();
  
        }
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
        public void AddDebt(ADebt debt)
        {
            _debts.Add(debt);
        }
        
        public List<string> GetAllAccountsAsString()
        {
            List<string> accounts = new List<string>();
            foreach (Account account in _accounts)
            {
                string accountInfo = $"{account.AccountNumber} c номером {account.BankName} с балансом = {account.Balance} с валюте {account.Currency}";
            }
            return accounts;
        }
    }
}
