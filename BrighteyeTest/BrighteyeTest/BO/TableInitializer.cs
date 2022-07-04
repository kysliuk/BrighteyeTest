using System.Data.Entity;
using System.Linq;

namespace BrighteyeTest
{
    //ToRefactory
    internal class TableInitializer
    {
        public void FillUnsortedTable(int[] numbers, DbSet<UnsortedNumber> table)
        {
            ClearUnsortedTable(table);
            foreach (var item in numbers)
            {
                var number = new UnsortedNumber { Value = item };
                table.Add(number);
            }
        }

        public void FillSortedTable(int[] numbers, DbSet<SortedNumber> table)
        {
            ClearSortedTable(table);
            foreach (var item in numbers)
            {
                var number = new SortedNumber { Value = item };
                table.Add(number);
            }
        }

        public int[] GetUnsortedNumbers(DbSet<UnsortedNumber> table)
        {
            int[] array = new int[table.ToList().Count()];
            int i = 0;
            foreach (var item in table.ToList())
            {
                array[i] = item.Value;
                i++;
            }
            return array;
        }

        private void ClearUnsortedTable(DbSet<UnsortedNumber> table)
        {
            foreach (var item in table) table.Remove(item);
        }

        private void ClearSortedTable(DbSet<SortedNumber> table)
        {
            foreach (var item in table) table.Remove(item);
        }
    }
}
