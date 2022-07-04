using System;

namespace BrighteyeTest
{
    internal class WindowInitializer
    {
        private static TableInitializer _tableInitializer = new TableInitializer();
        private static BrighteyeTestDBContext _brighteyeTestDBContext = new BrighteyeTestDBContext();

        private static int generationVariablesAmount = 10;

        internal static void InitiateGeneration()
        {
            _tableInitializer.FillUnsortedTable(Randomizer.CreateArray(generationVariablesAmount), _brighteyeTestDBContext.UnsortedNumbers);
            _brighteyeTestDBContext.SaveChanges();
        }

        internal static void InitiateSort()
        {
            _tableInitializer.FillSortedTable(Sorter.GetSortedArray(_tableInitializer.
                GetUnsortedNumbers(_brighteyeTestDBContext.UnsortedNumbers)), _brighteyeTestDBContext.SortedNumbers);
            _brighteyeTestDBContext.SaveChanges();
        }

        internal static string GetLableContent()
        {
            return "Generated values: " + string.Join(" ", _tableInitializer.GetUnsortedNumbers(_brighteyeTestDBContext.UnsortedNumbers));
        }

        internal static void ShowNotificationWindow(NotificationWindow notificationWindow)
        {
            notificationWindow.Hide();
            notificationWindow.Show();
        }

        internal static void CloseNotificationWindow(NotificationWindow notificationWindow)
        {
            notificationWindow.Close();
        }
    }
}
