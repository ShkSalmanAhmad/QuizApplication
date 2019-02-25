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
    /// Interaction logic for Round3Form.xaml
    /// </summary>
    public partial class Round3Form : Window
    {
        linklistop generalknowledgeround1;
        linklistop literatureround1;
        linklistop islamicstudiesround1;
        linklistop sportsround1;
        linklistop geographyround1;
        linklistop historyround1;
        linklistop entertainmentround1;
        linklistop generallistround2;

        DispatcherTimer dispatcherTimer;
        private int _timesCalled;

        Node ptr;
        Node tempptr;
        String category;

        public Round3Form()
        {
            InitializeComponent();
        }
        public Round3Form(linklistop gk, linklistop lit, linklistop isl, linklistop sp, linklistop geo, linklistop his, linklistop enter, linklistop round2list, String categroylocal)
        {
            InitializeComponent();
            generalknowledgeround1 = gk;
            literatureround1 = lit;
            islamicstudiesround1 = isl;
            sportsround1 = sp;
            geographyround1 = geo;
            historyround1 = his;
            entertainmentround1 = enter;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);

            generallistround2 = round2list;

            category = categroylocal;
            ptr = new Node();
            tempptr = new Node();
            newQuestion();

        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            String timescalledstring = this.TimerTextBlock.Text;
            if (timescalledstring == "00:40")
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

        private void PassQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            category = randomQuestion();
            newQuestion();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Round1Menu r1m = new Round1Menu(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2);
            r1m.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //newQuestion();
        }
        public void newQuestion()
        {
            while (true)
            {
                linklistop linklistnode = new linklistop();
                ptr = new Node();
                tempptr = ptr;
                if (category == "General Knowledge")
                {
                    ptr = generalknowledgeround1.returnquestionround1(ptr);
                    //generalknowledgeround1.show();
                }
                else if (category == "Islamic Studies")
                {
                    ptr = islamicstudiesround1.returnquestionround1(ptr);
                }
                else if (category == "History")
                {
                    ptr = historyround1.returnquestionround1(ptr);
                }
                else if (category == "Geography")
                {
                    ptr = geographyround1.returnquestionround1(ptr);
                }
                else if (category == "Sports")
                {
                    ptr = sportsround1.returnquestionround1(ptr);
                }
                else if (category == "Entertainment")
                {
                    ptr = entertainmentround1.returnquestionround1(ptr);
                }
                else if (category == "Literature")
                {
                    ptr = literatureround1.returnquestionround1(ptr);
                }
                if (ptr == null)
                {
                    MessageBox.Show("No more questions left from this category");
                    Round1Menu r1m = new Round1Menu(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2);
                    this.Hide();
                    r1m.Show();
                    //category = randomQuestion();
                }
                else
                {
                    this.TimerTextBlock.Text = String.Empty;
                    _timesCalled = 0;
                    dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                    dispatcherTimer.Start();
                    ptr.asked = true;
                    this.QuestionTextBlock.Text = ptr.question;
                    this.OptionATextBlock.Text = "A)" + ptr.optionA;
                    this.OptionBTextBlock.Text = "B)" + ptr.optionB;
                    this.OptionCTextBlock.Text = "C)" + ptr.optionC;
                    this.OptionDTextBlock.Text = "D)" + ptr.optionD;
                    if (ptr.imgpath != String.Empty)
                    {
                        this.Questionimage.Stretch = Stretch.Uniform;
                        this.Questionimage.Source = new BitmapImage(new Uri(ptr.imgpath));
                    }
                    return;
                }
            }
        }
        public String randomQuestion()
        {
            clearQuestionAnswer(ptr);
            //DispatcherTimer dispatcherTimer = new DispatcherTimer();
            //dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //_timesCalled = 0;
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            //dispatcherTimer.Start();
            linklistop linklistnode = new linklistop();
            ptr = new Node();
            Random rand = new Random();
            int num = 0;
            while (true)
            {
                num = rand.Next(1, 8);
                category = String.Empty;
                if (num == 1)
                {
                    category = "General Knowledge";
                    break;
                    //Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                    //this.Hide();
                    //r1cs.Show();
                }
                else if (num == 2)
                {
                    category = "Islamic Studies";
                    break;
                    //Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                    //this.Hide();
                    //r1cs.Show();
                }
                else if (num == 3)
                {
                    category = "History";
                    break;
                    //Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                    //this.Hide();
                    //r1cs.Show();
                }
                else if (num == 4)
                {
                    category = "Sports";
                    break;
                    //Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                    //this.Hide();
                    //r1cs.Show();
                }
                else if (num == 5)
                {
                    category = "Entertainment";
                    break;
                    //Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                    //this.Hide();
                    //r1cs.Show();
                }
                else if (num == 6)
                {
                    category = "Geography";
                    break;
                    //Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                    //this.Hide();
                    //r1cs.Show();
                }
                else if (num == 7)
                {
                    category = "Literature";
                    break;
                    //Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                    //this.Hide();
                    //r1cs.Show();
                }
            }
            return category;
            //newQuestion();
        }
        public void showQuestionAnswer(Node ptr)
        {
            if (ptr.answer == tempptr.optionA)
            {
                this.OptionATextBlock.Foreground = Brushes.Green;
            }
            else if (ptr.answer == tempptr.optionB)
            {
                this.OptionBTextBlock.Foreground = Brushes.Green;
            }
            else if (ptr.answer == tempptr.optionC)
            {
                this.OptionCTextBlock.Foreground = Brushes.Green;
            }
            else if (ptr.answer == tempptr.optionD)
            {
                this.OptionDTextBlock.Foreground = Brushes.Green;
            }
        }
        public void clearQuestionAnswer(Node ptr)
        {
            this.OptionATextBlock.Foreground = Brushes.Black;
            this.Questionimage.Source = null;
            this.OptionBTextBlock.Foreground = Brushes.Black;
            this.OptionCTextBlock.Foreground = Brushes.Black;
            this.OptionDTextBlock.Foreground = Brushes.Black;
            dispatcherTimer.Stop();
        }
    }
}
