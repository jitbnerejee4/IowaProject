using System;
using System.Windows;

namespace CountyAdjacencyChecker
{
    public partial class MainWindow : Window
    {
        private CountyAdjacency countyAdjacency;

        public MainWindow()
        {
            InitializeComponent();
            countyAdjacency = new CountyAdjacency();
        }

        private void CheckAdjacencyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int county1 = countyAdjacency.GetCountyID(County1TextBox.Text);
                int county2 = countyAdjacency.GetCountyID(County2TextBox.Text);

                bool result = countyAdjacency.AreCountiesAdjacent(county1, county2);
                ResultTextBlock.Text = result ? "Counties are adjacent." : "Counties are not adjacent.";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }
    }
}
