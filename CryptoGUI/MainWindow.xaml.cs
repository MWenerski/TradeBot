using System.Windows;

namespace CryptoGUI
{
    public partial class MainWindow : Window
    {
        private bool isTrading;

        public MainWindow()
        {
            InitializeComponent(); // This method is auto-generated
        }

        private void StartTrading_Click(object sender, RoutedEventArgs e)
        {
            if (!isTrading)
            {
                // Start trading logic here
                StartTrading();
                StatusTextBox.Text = "Trading started.";
                isTrading = true;
            }
            else
            {
                StatusTextBox.Text = "Trading is already running.";
            }
        }

        private void StopTrading_Click(object sender, RoutedEventArgs e)
        {
            if (isTrading)
            {
                // Stop trading logic here
                StopTrading();
                StatusTextBox.Text = "Trading stopped.";
                isTrading = false;
            }
            else
            {
                StatusTextBox.Text = "Trading is not running.";
            }
        }

        private void StartTrading()
        {
            // Add your start trading logic here
        }

        private void StopTrading()
        {
            // Add your stop trading logic here
        }
    }
}
