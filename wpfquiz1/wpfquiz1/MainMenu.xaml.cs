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
using System.Windows.Forms;
namespace wpfquiz1
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        linklistop generalknowledgeround1;
        linklistop literatureround1;
        linklistop islamicstudiesround1;
        linklistop sportsround1;
        linklistop geographyround1;
        linklistop historyround1;
        linklistop entertainmentround1;

        linklistop generallistround2;

        public MainMenu()
        {
            InitializeComponent();
        }
        String dir;
        public MainMenu(String Dir)
        {
            InitializeComponent();
            dir = Dir;
            generalknowledgeround1 = new linklistop();
            literatureround1 = new linklistop();
            islamicstudiesround1 = new linklistop();
            sportsround1 = new linklistop();
            geographyround1 = new linklistop();
            historyround1 = new linklistop();
            entertainmentround1 = new linklistop();

            generallistround2 = new linklistop();
            generalknowledgeround1.fillthelinklist(dir, "GeneralKnowledge");
            sportsround1.fillthelinklist(dir, "Sports");
            literatureround1.fillthelinklist(dir, "Literature");
            islamicstudiesround1.fillthelinklist(dir, "Islamiat");
            geographyround1.fillthelinklist(dir, "Geography");
            historyround1.fillthelinklist(dir, "History");
            entertainmentround1.fillthelinklist(dir, "Entertainment");

            generallistround2.fillround2(dir);
        }

        public MainMenu(linklistop gk, linklistop lit, linklistop isl, linklistop sp, linklistop geo, linklistop his, linklistop enter, linklistop round2list)
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
        }
        private void Round1Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int num = random.Next(7 + 1);
            String category = String.Empty;
            if (num == 1)
            {
                category = "General Knowledge";
                Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();

            }
            if (num == 2)
            {
                category = "Islamic Studies";
                Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 3)
            {
                category = "History";
                Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 4)
            {
                category = "Sports";
                Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 5)
            {
                category = "Entertainment";
                Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 6)
            {
                category = "Geography";
                Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 7)
            {
                category = "Literature";
                Round1Form r1cs = new Round1Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
        }

        private void Round2Button_Click(object sender, RoutedEventArgs e)
        {
            Round2Form r2f = new Round2Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1,generallistround2);
            this.Hide();
            r2f.Show();
        }

        private void Round3Button_Click(object sender, RoutedEventArgs e)
        {
            Round1Menu r1m = new Round1Menu(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2);
            this.Hide();
            r1m.Show();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
