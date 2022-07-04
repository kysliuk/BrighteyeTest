using System.Windows;

namespace BrighteyeTest
{
    public partial class MainWindow : Window
    {
        private NotificationWindow _notificationWindow = new NotificationWindow();

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            Closed += MainWindow_Closed;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SetDataContext();
        }

        private void MainWindow_Closed(object sender, System.EventArgs e)
        {
            WindowInitializer.CloseNotificationWindow(_notificationWindow);
        }

        private void OnGenerateButtonClick(object sender, RoutedEventArgs e)
        {
            WindowInitializer.InitiateGeneration();
            WindowInitializer.ShowNotificationWindow(_notificationWindow);
        }

        private void OnSortButtonClick(object sender, RoutedEventArgs e)
        {
            WindowInitializer.InitiateSort();
            SetDataContext();
        }

        private void SetDataContext()
        {
            DataContext = new TableViewModel();
        }
        

    }
}
