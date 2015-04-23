using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CorofinGAA
{
    public partial class ResultPage : PhoneApplicationPage
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {

            if (Scoreboard.correctAnswers >= 9)
            {
                resultBlock.Text = "You got " + Scoreboard.correctAnswers + " out of " + Scoreboard.totalAnswers + " Questions Correct\n\nBrillant, you're knowlege is great!";

            }

            else if (Scoreboard.correctAnswers >= 4)
            {

                resultBlock.Text = "You got " + Scoreboard.correctAnswers + " out of " + Scoreboard.totalAnswers + " Questions Correct\n\nNeed Work!";

            }

            else if (Scoreboard.correctAnswers >= 0)
            {
                resultBlock.Text = "You got " + Scoreboard.correctAnswers + " out of " + Scoreboard.totalAnswers + " Questions Correct\n\nPoor Effort!";

            }

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

    }
}