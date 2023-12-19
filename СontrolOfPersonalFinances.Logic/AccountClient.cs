using System;
using System.Collections.Generic;
using System.Windows.Documents;
using СontrolOfPersonalFinances.Logic.Model;

namespace СontrolOfPersonalFinances.Logic
{
    public class AccountClient
    {
        public List<Account> _accounts;// cчет
        public List<Debt> _debts;//долгов
        public List<Income> _incomes;//доходов
        public List<Expenditure> _expenditures;//расходов
        public Dictionary<string, string> _purchases;

        public AccountClient() 
        { 
            _accounts = new List<Account>();
            _debts = new List<Debt>();
            _incomes = new List<Income>();
            _expenditures = new List<Expenditure>();
            _purchases = new Dictionary<string, string>();
        }
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
        public void AddDebt(Debt debt)
        {
            _debts.Add(debt);
        }
        public void AddIncome(Income income)
        {
            _incomes.Add(income);
        }
        public void AddExpenditure(Expenditure expenditure)
        {
            _expenditures.Add(expenditure);
        }
        public List<string> GetAllAccountsAsString()
        {
            List<string> accounts = new List<string>();
            foreach (Account account in _accounts)
            {
                string accountInfo=$"{account.Name} c номером {account.TypeBank} с балансом = {account.AccountBalance}р.";
            }
             return accounts;
        }
    }
}
