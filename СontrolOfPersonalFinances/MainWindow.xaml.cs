using System;
using System.Collections.Generic;
using System.Linq;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AccountClient _accountClient;
        public MainWindow()
        {
            InitializeComponent();
            _accountClient = new AccountClient();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = "";
            string textBoxValue = TextBoxName.Text.Trim();
            string textBoxBalanceValue = TextBoxBalance.Text.Trim();
            string textBoxBankValue = TextBoxBank.Text.Trim();

            if(!string.IsNullOrEmpty(textBoxValue) )
            {

                // Определяем, какой радиобаттон был выбран
                if (Account.IsChecked == true)
                {
                    selectedItem = $"Счет {textBoxValue} в банке {textBoxBankValue}  баланс {textBoxBalanceValue}р.";
                }
                else if (DebtButton.IsChecked == true)
                {
                    selectedItem = "Долг" + textBoxValue;
                }
                else if (IncomeButton.IsChecked == true)
                {
                    selectedItem = "Доход" + textBoxValue;
                }
                else if (ExpenditureButton.IsChecked == true)
                {
                    selectedItem = "Расход" + textBoxValue;
                }
                // Добавляем выбранный элемент в ListBox
                ListBox.Items.Add(selectedItem);
            }
        }

    }
}
