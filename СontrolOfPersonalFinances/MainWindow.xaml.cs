using System;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
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
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
           
               AccountModel newAccount = new AccountModel();
               newAccount.AccountNumber = NumberLabelText.Text;
               newAccount.BankName = TextBoxBank.Text;
               newAccount.Balance = decimal.Parse(BalansLabelText.Text);
               newAccount.Currency = TextBoxCurrent.Text;
               newAccount.Comment = CommentsBox.Text;
               newAccount.Id = Int32.Parse(IdBox.Text); 
               _accountingSystem._accounts.Add(Convert.ToInt32(AccountType.Cash), newAccount);
               ListBoxOne.Items.Add($"{currentTime} Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency} , Ваш ID : {newAccount.Id}, Комментарий:{newAccount.Comment}");
               ListBoxOne.Items.Clear();

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
    }
}
       