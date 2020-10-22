using System;
using System.Collections.Generic;
using System.IO;
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
        double gameScore1;
        double gameScore2;
        double gameScore3;
        int tieAmount;
        double totalScore;
        double averageScore;
        double handicapScore;
        string valString;

        public MainWindow()
        {
            InitializeComponent();
            yourName.Text = yourName.Text + "'s Bowling Stats";

            if (Male.IsChecked == true)
            {
                yourGender.Text = "Male";
            }
            else if (Female.IsChecked == true)
            {
                yourGender.Text = "Female";
            }
            else if (Other.IsChecked == true)
            {
                yourGender.Text = "Other";
            }
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
            Female.IsChecked = false;
            Male.IsChecked = false;
            Other.IsChecked = false;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e) //Done//
        {
            this.Close();
        }

        private void Game1_TextChanged(object sender, TextChangedEventArgs e)
        {
            gameScore1 = double.Parse(Game1.Text);
        }

        private void Game2_TextChanged(object sender, TextChangedEventArgs e)
        {
            gameScore2 = double.Parse(Game2.Text);
        }

        private void Game3_TextChanged(object sender, TextChangedEventArgs e)
        {
            gameScore3 = double.Parse(Game3.Text);
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            totalScore = gameScore1 + gameScore2 + gameScore3;
            averageScore = (gameScore1 + gameScore2 + gameScore3) / 3;
            handicapScore = (200 - averageScore) * .8;
            var game_series = new List<int> { Convert.ToInt32(gameScore1), Convert.ToInt32(gameScore2), Convert.ToInt32(gameScore3)};
            int maxValue = game_series.Max();
            TotalScore.Text = Convert.ToString(totalScore);
            AverageScore.Text = Convert.ToString(averageScore);
            HandicapScore.Text = Convert.ToString(handicapScore);
            HighGame.Text = Convert.ToString(maxValue);
            for (int i = 0; i < game_series.Count();)
            {
                if (game_series[i] == maxValue)
                {
                    tieAmount++;
                    int game_seriesVal = i + 1;
                    if (tieAmount == 1)
                    {
                        valString = " game " + game_seriesVal + ", and";
                    }
                    else
                    {
                        valString += " game " + game_seriesVal;
                    }
                }
                i++;
            }
            if (tieAmount == 2)
            {
                HighGame.Text = "Tie" + valString + ".";
            }
            if (tieAmount == 3)
            {
                HighGame.Text = "Three way tie";
            }
        }
    }
}
