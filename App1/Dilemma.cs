using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Dilemma
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public int CorrectAnswer { get; set; }

        public Dilemma(string question, string answer1, string answer2, string answer3, int correctAnswer)
        {
            Question = question;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            CorrectAnswer = correctAnswer;
        }

        public Dilemma()
        {
        }

        static Random rnd = new Random();
        Player player = new Player(0);

        public List<Dilemma> questions = new List<Dilemma>();
        Dilemma question1 = new Dilemma("Hvad er WannaCry?", "Keylogger", "Trojan Horse", "RansomWare angreb", 3);
        Dilemma question2 = new Dilemma("Hvad er Malware?", "Malicious Software", "Malfunctioning Harware", "Wallmarts Shopping app", 1);

        public List<Dilemma> FillList()
        {
            questions.Add(question1);
            questions.Add(question2);
            return questions;
        }

        public void CorrectAnswerPoints(int number, Dilemma dilemma, int randomNumber)
        {
            if (number == dilemma.CorrectAnswer)
            {
                player.Points = +10;
            }
            questions.Remove(questions[randomNumber]);
        }

    }
}
