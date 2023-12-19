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

namespace СontrolOfPersonalFinances
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = "";

            // Определяем, какой радиобаттон был выбран
            if (Account.IsChecked == true)
            {
                selectedItem = "Счет";
            }
            else if (DebtButton.IsChecked == true)
            {
                selectedItem = "Долг";
            }
            else if (IncomeButton.IsChecked == true)
            {
                selectedItem = "Доход";
            }
            else if (ExpenditureButton.IsChecked == true)
            {
                selectedItem = "Расход";
            }

            // Добавляем выбранный элемент в ListBox
            ListBox.Items.Add(selectedItem);
        }
    }
}
