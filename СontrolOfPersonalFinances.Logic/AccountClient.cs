using System;
using System.Collections.Generic;
using System.Windows.Documents;
using СontrolOfPersonalFinances.Logic.Model;

namespace СontrolOfPersonalFinances.Logic
{
    public class AccountClient
    {
        private List<Account> _accounts;// cчет
        private List<Debt> _debts;//долгов
        private List<Income> _incomes;//доходов
        private List<Expenditure> _expenditures;//расходов

        public AccountClient() 
        { 
            _accounts = new List<Account>();
            _debts = new List<Debt>();
            _incomes = new List<Income>();
            _expenditures = new List<Expenditure>();
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
                string accountInfo=$"{account.Name} c номером {account.AccountID} с балансом = {account.AccountBalance}р.";
            }
             return accounts;
        }
    }
}
