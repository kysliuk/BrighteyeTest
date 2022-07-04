using System.Windows;
using System;

namespace BrighteyeTest
{
    public partial class NotificationWindow : Window
    {
        public NotificationWindow()
        {
            InitializeComponent();
            Activated += NotificationWindow_Activated;
        }

        private void NotificationWindow_Activated(object sender, EventArgs e)
        {
            notificationLabel.Content = WindowInitializer.GetLableContent();

        }

        private void OnOkButtonClick(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
