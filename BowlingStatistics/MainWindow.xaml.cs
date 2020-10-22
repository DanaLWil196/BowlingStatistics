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

namespace BowlingStatistics
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

        private void ClearButton_Click(object sender, RoutedEventArgs e) //Done//
        {
            yourName.Text = "";
            Game1.Text = "";
            Game2.Text = "";
            Game3.Text = "";
            TotalScore.Text = "";
            AverageScore.Text = "";
            HandicapScore.Text = "";
            HighGame.Text = "";
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e) //Done//
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
