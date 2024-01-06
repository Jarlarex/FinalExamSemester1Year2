using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamSemester1Year2
{
    public enum BudgetItemType 
    {
        Income,
        Expense
    }

    class BudgetItem : IComparable<BudgetItem>
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public BudgetItemType ItemType { get; set; }
        public DateTime Date { get; set; }
        public bool Recurring { get; set; }

        public int CompareTo(BudgetItem other)
        {
            if (other == null) return 1;
            return this.Date.Day.CompareTo(other.Date.Day);
        }

        public override string ToString()
        {
            string recurring = Recurring ? "Recurring" : "One Off";
            return $"{Date.Day} : {Name} €{Amount:f2} - ({recurring})";
        }
    }

}
