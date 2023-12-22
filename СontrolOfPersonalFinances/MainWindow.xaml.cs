using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using СontrolOfPersonalFinances.Logic.Enums;
using СontrolOfPersonalFinances.Logic.Model;

namespace СontrolOfPersonalFinances
{
    public partial class MainWindow : Window
    {
        PersonalFinanceAccountingSystem _accountingSystem { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            _accountingSystem = new PersonalFinanceAccountingSystem();
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string selectedItem = "";

            if (Account.IsChecked == true)
            {
                selectedItem = "Кредитная карта";
                AccountModel newAccount = new AccountModel();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = BankLabelText.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = СurrencyLabelText.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = IdBox.Text; 

                _accountingSystem._accounts.Add(AccountType.CreditCard,newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency} ,ID операции {newAccount.Id},Комментарий:{newAccount.Comment}");
            }
            else if (Cash.IsChecked == true)
            {
                selectedItem = "Наличные";
                AccountModel newAccount = new AccountModel();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = BankLabelText.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = СurrencyLabelText.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = IdBox.Text;

                _accountingSystem._accounts.Add(AccountType.Cash, newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency}");

            }

            else if (DebetCart.IsChecked == true)
            {
                selectedItem = "Дебетовая карта";
                AccountModel newAccount = new AccountModel();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = BankLabelText.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = СurrencyLabelText.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = IdBox.Text;

                _accountingSystem._accounts.Add(AccountType.DebetCard, newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency}, ID операции {newAccount.Id},Комментарий:{newAccount.Comment}");
            }
            else if (Debt.IsChecked == true)
            {
                selectedItem = "Долг";
                AccountModel newAccount = new AccountModel();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = BankLabelText.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = СurrencyLabelText.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = IdBox.Text;

                _accountingSystem._accounts.Add(AccountType.Debt, newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency} , ID операции {newAccount.Id},Комментарий:{newAccount.Comment}");

            }
                 //private void ShowAccountsButton_Click(object sender, RoutedEventArgs e)

                 //{
                 //  string currentTime = DateTime.Now.ToString("HH:mm:ss");
                 // foreach (AccountModel account in _accountingSystem.)
                 //  {
                 //        ShowAccountsList.Items.Add($"{currentTime} Номер счета :{account.AccountNumber},Название банка :{account.BankName},Баланс:{account.Balance}");
                 //  }

        }

       
    }
}
       