using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DilemmaPage : Page
    {
        static Random rnd = new Random();
        Player player = new Player(0);
        Dilemma dilemma = new Dilemma();
        int randomNumber;
        public DilemmaPage()
        {
            this.InitializeComponent();

            List<Dilemma> questions = dilemma.questions;

            randomNumber = rnd.Next(0, questions.Count);

            QuestionBlock.Text = questions[randomNumber].Question;
            Answer1Button.Content = "1. " + questions[randomNumber].Answer1;
            Answer2Button.Content = "2. " + questions[randomNumber].Answer2;
            Answer3Button.Content = "3. " + questions[randomNumber].Answer3;
        }

        private void Answer1Button_Click(object sender, RoutedEventArgs e)
        {
            dilemma.CorrectAnswerPoints(1, dilemma.questions[randomNumber], randomNumber);
        }

        private void Answer2Button_Click(object sender, RoutedEventArgs e)
        {
            dilemma.CorrectAnswerPoints(2, dilemma.questions[randomNumber], randomNumber);
        }

        private void Answer3Button_Click(object sender, RoutedEventArgs e)
        {
            dilemma.CorrectAnswerPoints(3, dilemma.questions[randomNumber], randomNumber);
        }


    }
}
