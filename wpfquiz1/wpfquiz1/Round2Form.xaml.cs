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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace wpfquiz1
{
    /// <summary>
    /// Interaction logic for Round2Form.xaml
    /// </summary>
    public partial class Round2Form : Window
    {
        linklistop generalknowledgeround1;
        linklistop literatureround1;
        linklistop islamicstudiesround1;
        linklistop sportsround1;
        linklistop geographyround1;
        linklistop historyround1;
        linklistop entertainmentround1;
        linklistop generallistround2;
        Node ptr;
        Node tempptr;
        DispatcherTimer dispatcherTimer;
        private int _timesCalled;

        public Round2Form()
        {
            InitializeComponent();
        }
        public Round2Form(linklistop gk, linklistop lit, linklistop isl, linklistop sp, linklistop geo, linklistop his, linklistop enter, linklistop round2list)
        {
            InitializeComponent();
            generalknowledgeround1 = gk;
            literatureround1 = lit;
            islamicstudiesround1 = isl;
            sportsround1 = sp;
            geographyround1 = geo;
            historyround1 = his;
            entertainmentround1 = enter;

            generallistround2 = round2list;
            ptr = new Node();
            tempptr = new Node();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);

        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            String timescalledstring = this.TimerTextBlock.Text;
            if (timescalledstring == "00:30")
            {
                this.TimerTextBlock.Foreground = Brushes.Red;
            }
            else
            {
                _timesCalled++;
                TimeSpan result = TimeSpan.FromSeconds(_timesCalled);
                string fromTimeString = result.ToString("mm':'ss");
                this.TimerTextBlock.Text = fromTimeString;
            }
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            showQuestionAnswer(ptr);
        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu r1m = new MainMenu(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1,generallistround2);
            this.Hide();
            r1m.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.AnswerTextBlock.Visibility = Visibility.Hidden;
            newQuestion();
        }
        public void newQuestion()
        {
            ptr = new Node();
            tempptr = ptr;
            ptr = generallistround2.returnquestionround2(ptr);
            ptr.asked = true;
            this.QuestionTextBlock.Text = ptr.question;
            if (ptr.imgpath != String.Empty)
            {
                this.Questionimage.Source = new BitmapImage(new Uri(ptr.imgpath));
            }
            this.TimerTextBlock.Text = String.Empty;
            _timesCalled = 0;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        public void showQuestionAnswer(Node ptr)
        {
            if (ptr.answer == tempptr.optionA)
            {
                this.AnswerTextBlock.Visibility = Visibility.Visible;
                this.AnswerTextBlock.Text = ptr.answer;
            }
        }
        public void clearQuestionAnswer(Node ptr)
        {
            if (ptr.answer == tempptr.optionA)
            {
                this.AnswerTextBlock.Text = "Answer";
            }
            this.TimerTextBlock.Text = String.Empty;
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            clearQuestionAnswer(ptr);
            newQuestion();
            //generallistround2.show();
            //Round2Form r2f = new Round2Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2);
            //this.Hide();
            //r2f.Show();
        }
    }
}
