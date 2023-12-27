using System;
using System.Security.Principal;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using СontrolOfPersonalFinances.Logic.Enums;
using СontrolOfPersonalFinances.Logic.Model;
using СontrolOfPersonalFinances.Logic.Models;

namespace СontrolOfPersonalFinances
{
    public partial class MainWindow : Window
    {
        PersonalFinanceAccountingSystem _accountingSystem { get; set; }
       
        public MainWindow()
        {
            InitializeComponent();
            _accountingSystem = new PersonalFinanceAccountingSystem();

            this.BankSelect.ItemsSource = new string[] { "Сбербанк", "ВТБ" ,"Открытие","Альфа-Бфнк" };
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string selectedItem = "";


            if (DebitCard_.IsChecked == true)
            {
                selectedItem = "Дебетовая карта";
                AccountModel newAccount = new AccountModel();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = this.BankSelect.SelectedValue.ToString();
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = TextBoxCurrent.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = Int32.Parse(IdBox.Text);
                
                _accountingSystem._accounts.Add(Convert.ToInt32(AccountType.DebetCard), newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency} ,ID операции {newAccount.Id},Комментарий:{newAccount.Comment}");
            }
            else if (CreditCard.IsChecked == true)
            {
                selectedItem = "Кредитная карта";
                AccountModel newAccount = new AccountModel();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = BankSelect.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = TextBoxCurrent.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = Int32.Parse(IdBox.Text);

                _accountingSystem._accounts.Add(Convert.ToInt32(AccountType.CreditCard), newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency}");

            }
            else if (Cash.IsChecked == true)
            {
                selectedItem = "Наличные";
                AccountModel newAccount = new AccountModel();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = BankSelect.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = TextBoxCurrent.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = Int32.Parse(IdBox.Text);

                _accountingSystem._accounts.Add(Convert.ToInt32(AccountType.Cash), newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency}, ID операции {newAccount.Id},Комментарий:{newAccount.Comment}");
            }
            else if (Debt1.IsChecked == true)
            {
                selectedItem = "Долг";
                AccountModel newAccount = new AccountModel();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = BankSelect.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = TextBoxCurrent.Text;
                newAccount.Comment = CommentsBox.Text;
                newAccount.Id = Int32.Parse(IdBox.Text);

                _accountingSystem._accounts.Add(Convert.ToInt32(AccountType.Cash), newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem} , Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта:{newAccount.Currency}, ID операции {newAccount.Id},Комментарий:{newAccount.Comment}");
            }
        }
         private void AddMoney_Click(object sender, RoutedEventArgs e)
        {
            AccountModel account = new AccountModel();
            account.AccountNumber = NumberText.Text;
            int summ = Int32.Parse(SummText.Text);
            _accountingSystem.AddMomey(account, summ);
            ListBoxOne.Items.Add($" Ваш баланс: {account.Balance}");
        }

        private void WithdrawMoney_Click(object sender, RoutedEventArgs e)
        {
            AccountModel model = new AccountModel();
            model.AccountNumber = NumberText.Text;
            int summ =Int32.Parse(SummText.Text);
            _accountingSystem.WithdrawMoney(model, summ);
            ListBoxOne.Items.Add($" Ваш баланс: {model.Balance}");
        }

        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryModel model = new CategoryModel();
            model.Name = NameCategoryText.Text;
            _accountingSystem.AddCategory(model);
            List.Items.Add($"Добавлена категория :{model.Name}");
        }

        private void DeleteCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryModel category = new CategoryModel();
            category.Name = NameCategoryText.Text;
            int Id = Int32.Parse(CategoryIdText.Text);
            _accountingSystem.DeleteTransactionById(Id);
            List.Items.Add($"Удалена категория с ID номером :{category.Id}");
        }

        private void IDCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            CategoryModel model = new CategoryModel();
            model.Name = NameCategoryText.Text;
            int Id =Int32.Parse(CategoryIdText.Text);
            _accountingSystem.GetCategoryModelById(Id);
            List.Items.Add($"Все категории с ID номером :{model.Id}");
        }

        private void CategoryList_Click(object sender, RoutedEventArgs e)
        {
            CategoryModel model = new CategoryModel();
            _accountingSystem.GetAllCategoryModels();
            List.Items.Add(_accountingSystem.GetAllCategoryModels);
        }

        private void AddTransaction_Click(object sender, RoutedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            TransactionModel transaction = new TransactionModel();
            transaction.Name = NumberAcc.Text;
            transaction.Summ = decimal.Parse(Summ.Text);
            transaction.Id =Int32.Parse(NumberID.Text);

            _accountingSystem._transactions.Add(TabIndex, transaction);
            ListBox.Items.Add($"{currentTime} Вы добавили ,Номер счета:{transaction.Name},Cумму:{transaction.Summ},Номер ID :{transaction.Id}");
        }

        private void RemoveTransactoin_Click(object sender, RoutedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            TransactionModel transaction = new TransactionModel();
            transaction.Name = NumberAcc.Text;
            transaction.Id=Int32.Parse(NumberID.Text);
            _accountingSystem.DeleteTransactionById(transaction.Id);
            ListBox.Items.Add($"{currentTime} Вы удалили, Номер счета:{transaction.Name},Cумму:{transaction.Summ},Номер ID :{transaction.Id}");
        }

        private void TransactionID_Click(object sender, RoutedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            TransactionModel transaction = new TransactionModel();
            transaction.Name = NumberAcc.Text;
            transaction.Id = Int32.Parse(NumberID.Text);
            _accountingSystem.GetCategoryModelById(transaction.Id);
            ListBox.Items.Add($"{currentTime} Номер счета:{transaction.Name},Cумму:{transaction.Summ},Номер ID :{transaction.Id}");
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            TransactionModel transaction = new TransactionModel();
            transaction.Name = NumberAcc.Text;
            transaction.Id = Int32.Parse(NumberID.Text);
            transaction.Summ=decimal.Parse(Summ.Text);
            _accountingSystem.GetAllTransactionModels();
            ListBox.Items.Add($"{currentTime} Номер счета:{transaction.Name},Cумму:{transaction.Summ},Номер ID :{transaction.Id}");
        }

        private void Forecast_Click(object sender, RoutedEventArgs e)
        {
            PersonalFinanceAccountingSystem system = new PersonalFinanceAccountingSystem();
            string monthlyForecast = Convert.ToString(_accountingSystem.CreateMonthlyForecast());
            ForecastList.Items.Add($"Прогноз на месяц : {monthlyForecast}");
        }
    }
}
       