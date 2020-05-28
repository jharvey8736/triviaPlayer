using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Xml.Schema;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        int gameNum = 0;
        //question lists
        List<string> categories;
        List<string> questions;
        List<string> answers;

        //result lists
        List<int> p1Scores;
        List<int> p2Scores;
        List<string> times;

        public MainWindow()
        {
            InitializeComponent();
            gameIDEntered.Text = getGameNum().ToString();
        }

        private async void UpdateQuestions(int gameID)
        {

            for (int i = 0; i < questions.Count; i++)
            {
                textType.Text = "CATEGORY";
                body.Text = categories[i];
                await Task.Delay(3000);
                textType.Text = "QUESTION";
                body.Text = questions[i];
                await Task.Delay(10000);
                textType.Text = "ANSWER";
                body.Text = answers[i];
                await Task.Delay(3000);
            }
            GameOver();
        }

        private void readQuestions()
        {
            categories = new List<string>();
            questions = new List<string>();
            answers = new List<string>();

            StreamReader reader = new StreamReader(@"questionFile.csv");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split('~');
                if (int.Parse(values[0]) < gameNum)
                    continue;
                else if (int.Parse(values[0]) > gameNum)
                    break;
                categories.Add(values[1]);
                questions.Add(values[2]);
                answers.Add(values[3]);
            }
            reader.Close();
        }

        private void GameOver()
        {
            UpdateGame();
            p1Score.Visibility = Visibility.Visible;
            p2Score.Visibility = Visibility.Visible;
            p1.Visibility = Visibility.Visible;
            p2.Visibility = Visibility.Visible;
            storeButton.Visibility = Visibility.Visible;
            body.Visibility = Visibility.Collapsed;
            textType.Visibility = Visibility.Collapsed;
        }

        private void UpdateGame()
        {
            StreamWriter writer = new StreamWriter(path + "\\currentGame.txt");
            writer.WriteLine((++gameNum).ToString());
            writer.Close();
        }

        private int getGameNum()
        {
            if (File.Exists(path + "\\currentGame.txt") && new FileInfo(path + "\\currentGame.txt").Length > 0)
            {
                StreamReader reader = new StreamReader(path + "\\currentGame.txt");
                int num = int.Parse(reader.ReadLine());
                reader.Close();
                gameNum = num;
                return num;
            }
            else
            {
                StreamWriter writer = new StreamWriter(path + "\\currentGame.txt");
                writer.Write("1");
                gameNum = 1;
                writer.Close();
                return gameNum;
            }
        }

        private void WriteResults()
        {   
            string result = p1Score.Text + "," + p2Score.Text + "," + DateTime.Now.ToString();
            StreamWriter myWriter = File.AppendText(path + "\\scoreHistory.txt");
            myWriter.WriteLine(result);
            myWriter.Close();
        }

        private void ShowStats()
        {
            p1Wins.Visibility = Visibility.Visible;
            p1WinsCount.Visibility = Visibility.Visible;
            p2Wins.Visibility = Visibility.Visible;
            p2WinsCount.Visibility = Visibility.Visible;
            ties.Visibility = Visibility.Visible;
            tiesCount.Visibility = Visibility.Visible;
            p1Avg.Visibility = Visibility.Visible;
            p1AvgCount.Visibility = Visibility.Visible;
            p2Avg.Visibility = Visibility.Visible;
            p2AvgCount.Visibility = Visibility.Visible;
            SetScores();
            p1WinsCount.Text = getP1Wins().ToString();
            p2WinsCount.Text = getP2Wins().ToString();
            tiesCount.Text = getTies().ToString();
            p1AvgCount.Text = getP1Avg().ToString();
            p2AvgCount.Text = getP2Avg().ToString();
        }

        private void SetScores()
        {
            p1Scores = new List<int>();
            p2Scores = new List<int>();
            times = new List<string>();

            StreamReader reader = new StreamReader(path + "\\scoreHistory.txt");
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                p1Scores.Add(int.Parse(values[0]));
                p2Scores.Add(int.Parse(values[1]));
                answers.Add(values[2]);
            }
            reader.Close();
        }

        private int getP1Wins()
        {
            int wins = 0;
            for (int i = 0; i < p1Scores.Count; i++)
                if (p1Scores[i] > p2Scores[i])
                    wins++;
            return wins;
        }

        private int getP2Wins()
        {
            int wins = 0;
            for (int i = 0; i < p1Scores.Count; i++)
                if (p1Scores[i] < p2Scores[i])
                    wins++;
            return wins;
        }
        private int getTies()
        {
            int ties = 0;
            for (int i = 0; i < p1Scores.Count; i++)
                if (p1Scores[i] == p2Scores[i])
                    ties++;
            return ties;
        }

        private int getP1Avg()
        {
            int total = 0;
            for (int i = 0; i < p1Scores.Count; i++)
                total += p1Scores[i];
            return total / p1Scores.Count;
        }
        private int getP2Avg()
        {
            int total = 0;
            for (int i = 0; i < p1Scores.Count; i++)
                total += p2Scores[i];
            return total / p1Scores.Count;
        }

        private void startButton_Click(Object sender, RoutedEventArgs e)
        {
            textLabel.Visibility = Visibility.Collapsed;
            startButton.Visibility = Visibility.Collapsed;
            gameNum = int.Parse(gameIDEntered.Text);
            gameIDEntered.Visibility = Visibility.Collapsed;
            readQuestions();
            UpdateQuestions(gameNum);
        }

        private void storeButton_Click(Object sender, RoutedEventArgs e)
        {
            p1Score.Visibility = Visibility.Collapsed;
            p2Score.Visibility = Visibility.Collapsed;
            p1.Visibility = Visibility.Collapsed;
            p2.Visibility = Visibility.Collapsed;
            storeButton.Visibility = Visibility.Collapsed;
            WriteResults();
            ShowStats();
        }

        private void gameIDEntered_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       
    }
}