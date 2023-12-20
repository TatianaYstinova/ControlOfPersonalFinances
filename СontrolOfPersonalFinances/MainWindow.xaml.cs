using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using СontrolOfPersonalFinances.Logic;
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
                selectedItem = "Счет";
                Account newAccount = new Account();
                newAccount.AccountNumber = NumberLabelText.Text;
                newAccount.BankName = BankLabelText.Text;
                newAccount.Balance = decimal.Parse(BalansLabelText.Text);
                newAccount.Currency = СurrencyLabelText.Text;

                _accountingSystem.accounts.Add(newAccount);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newAccount.AccountNumber}, Название банка: {newAccount.BankName}, Баланс: {newAccount.Balance}, Валюта: {newAccount.Currency}");
            }
            else if (Cretdit.IsChecked == true)
            {
                selectedItem = "Кредит";
                Credit newCredit = new Credit();
                newCredit.AccountNumber = NumberLabelText.Text;
                newCredit.BankName = BankLabelText.Text;
                newCredit.Balance = decimal.Parse(BalansLabelText.Text);
                newCredit.InterestRate = Convert.ToDecimal(InterestRateLabelText.Text);
                newCredit.Term = int.Parse(TermLabelText.Text);

                _accountingSystem.сredit.Add(newCredit);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newCredit.AccountNumber}, Название банка: {newCredit.BankName}, Баланс: {newCredit.Balance}, Процентная ставка: {newCredit.InterestRate}, Срок: {newCredit.Term}");

            }
            else if (Installment.IsChecked == true)
            {
                selectedItem = "Рассрочка";
                Installment newInstallment = new Installment();
                newInstallment.AccountNumber = NumberLabelText.Text;
                newInstallment.BankName = BankLabelText.Text;
                newInstallment.Balance = decimal.Parse(BalansLabelText.Text);
                newInstallment.Term = int.Parse(TermLabelText.Text);

                _accountingSystem.installment.Add(newInstallment);
                ListBoxOne.Items.Add($"{currentTime}Тип: {selectedItem}, Номер счета: {newInstallment.AccountNumber}, Название банка: {newInstallment.BankName}, Баланс: {newInstallment.Balance}, Срок: {newInstallment.Term}");
            }

        }

        private void AccountReportButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < _accountingSystem.accounts.Count; i++)
            {
                
            }
            foreach(var account in _accountingSystem.accounts)
            {

            }
        }    
    }
}
       