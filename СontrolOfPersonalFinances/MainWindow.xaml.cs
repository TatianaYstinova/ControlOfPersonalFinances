using System;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
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
               newAccount.BankName = TextBoxBank.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = TextBoxCurrent.Text;
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
                newAccount.BankName = TextBoxBank.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency =TextBoxCurrent.Text;
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
                newAccount.BankName = TextBoxBank.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = TextBoxCurrent.Text;
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
                newAccount.BankName =TextBoxBank.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = TextBoxCurrent.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = IdBox.Text;

                _accountingSystem._accounts.Add(AccountType.Debt, newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency} , ID операции {newAccount.Id},Комментарий:{newAccount.Comment}");

            }
        }

        private void ShowAccountsButton_Click(object sender, RoutedEventArgs e)
        {
            if(_accountingSystem._transactions.Count == null && _accountingSystem._accounts.Count == null && _accountingSystem._categories.Count== null) 
            {
                ShowAccountsList.Items.Add("Информация отсутствует");
            }
            else
            {
                ShowAccountsList.Items.Add("Транзакции:");
                foreach(var transaction in _accountingSystem._transactions)
                {
                    ShowAccountsList.Items.Add($"Тип транзакции:{transaction.Key}, модель транзакции:{transaction.Value}");
                }
                ShowAccountsList.Items.Add("Счета:");
                foreach(var account in _accountingSystem._accounts)
                {
                    ShowAccountsList.Items.Add($"Тип учетной записи:{account.Key},модель учетной записи:{account.Value}");
                }
                ShowAccountsList.Items.Add("Категории");
                foreach(var category in _accountingSystem._categories)
                {
                    ShowAccountsList.Items.Add($"Катерогии по ID: {category.Key}, модель категории: {category.Value}");
                }
            }
        }
        private void AddMoney_Click(object sender, RoutedEventArgs e)
        {
            AccountModel account = new AccountModel();
            account.Balance = decimal.Parse(NumberText.Text);
            int summ = Int32.Parse(SummText.Text);
            _accountingSystem.AddMomey(account, summ);
            ListBoxOne.Items.Add(account.Balance);
        }

        private void WithdrawMoney_Click(object sender, RoutedEventArgs e)
        {
            AccountModel model = new AccountModel();
            model.Balance = decimal.Parse(NumberText.Text);
            int summ =Int32.Parse(SummText.Text);
            _accountingSystem.WithdrawMoney(model, summ);
            ListBoxOne.Items.Add(model.Balance);
        }
    }
}
       