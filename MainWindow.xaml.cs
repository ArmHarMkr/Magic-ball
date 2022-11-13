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

namespace MagicBall
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string question = "";
        Random random = new Random();
        List<string> answers = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            // Yes answers
            answers.Add("It is certain.");
            answers.Add("It is decidedly so.");
            answers.Add("Without a doubt.");
            answers.Add("Yes definitely.");
            answers.Add("You may rely on it.");
            // Middle ground answers
            answers.Add("As I see it, yes.");
            answers.Add("Most likely.");
            answers.Add("Outlook good.");
            answers.Add("Yes.");
            answers.Add("Signs point to yes.");
            answers.Add("Reply hazy, try again.");
            answers.Add("Ask again later.");
            answers.Add("Better not tell you now.");
            answers.Add("Cannot predict now.");
            answers.Add("Concentrate and ask again.");
            // No answers
            answers.Add("Don't count on it.");
            answers.Add("My reply is no.");
            answers.Add("My sources say no.");
            answers.Add("Outlook not so good.");
            answers.Add("Very doubtful.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            question = questionBlock.Text;
            int index = random.Next(answers.Count);
            lblAnswer.Content = answers[index];
            question = "";
            questionBlock.Text = "";
        }
    }
}
