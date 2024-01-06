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

namespace FinalExamSemester1Year2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //LINK TO GITHUB REPOSITORY: https://github.com/Jarlarex/FinalExamSemester1Year2

    public partial class MainWindow : Window
    {
        //List to hold the budget items
        private List<BudgetItem> itemType = new List<BudgetItem>();

        public MainWindow()
        {
            InitializeComponent();
            //Initialize and load data when application is started
            GetData();
            LoadItems();
        }

        //Method to populate data
        public void GetData()
        {
            itemType.Add(new BudgetItem { Name = "Grant", Amount = 300, ItemType = BudgetItemType.Income, Date = new DateTime(2024, 1, 5), Recurring = true });
            itemType.Add(new BudgetItem { Name = "Bonus", Amount = 300, ItemType = BudgetItemType.Income, Date = new DateTime(2024, 1, 15), Recurring = false });
            itemType.Add(new BudgetItem { Name = "Wages", Amount = 100, ItemType = BudgetItemType.Income, Date = new DateTime(2024, 1, 25), Recurring = true });
            itemType.Add(new BudgetItem { Name = "Rent", Amount = 400, ItemType = BudgetItemType.Expense, Date = new DateTime(2024, 1, 1), Recurring = true });
            itemType.Add(new BudgetItem { Name = "Flight", Amount = 100, ItemType = BudgetItemType.Expense, Date = new DateTime(2024, 1, 5), Recurring = false });
            itemType.Add(new BudgetItem { Name = "Netflix", Amount = 10, ItemType = BudgetItemType.Expense, Date = new DateTime(2024, 1, 15), Recurring = true });
            itemType.Add(new BudgetItem { Name = "Spotify", Amount = 8, ItemType = BudgetItemType.Expense, Date = new DateTime(2024, 1, 20), Recurring = true });
            

        }

        //Method to load items to the list boxes
        private void LoadItems()
        {
            lbxIncome.ItemsSource = itemType.Where(i => i.ItemType == BudgetItemType.Income);
            lbxExpenses.ItemsSource = itemType.Where(i => i.ItemType == BudgetItemType.Expense);
            decimal totalIncome = itemType.Where(i => i.ItemType == BudgetItemType.Income).Sum(i => i.Amount);
            lblTotalIncome.Content = $"Total Income: €{totalIncome:f2}";
            decimal totalExpense = itemType.Where(i => i.ItemType == BudgetItemType.Expense).Sum(i => i.Amount);
            lblTotalOutgoing.Content = $"Total Outgoings: €{totalExpense:f2}";
            decimal currentBalance = totalIncome - totalExpense;
            lblCurrentBalance.Content = $"Current Balance: €{currentBalance:f2}";
        }





        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
