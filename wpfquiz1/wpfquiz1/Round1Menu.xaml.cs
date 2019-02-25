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

namespace wpfquiz1
{
    /// <summary>
    /// Interaction logic for Round1Menu.xaml
    /// </summary>
    public partial class Round1Menu : Window
    {
        String category;
        linklistop generalknowledgeround1;
        linklistop literatureround1;
        linklistop islamicstudiesround1;
        linklistop sportsround1;
        linklistop geographyround1;
        linklistop historyround1;
        linklistop entertainmentround1;
        linklistop generallistround2;
        Random random = new Random();


        public Round1Menu()
        {
            InitializeComponent();
        }
        public Round1Menu(linklistop gk, linklistop lit, linklistop isl, linklistop sp, linklistop geo, linklistop his, linklistop enter, linklistop round2list)
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


        private void GeneralKnowledgeButton_Click(object sender, RoutedEventArgs e)
        {
            category = "General Knowledge";
            Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
            r1cs.Show();
            this.Hide();
        }

        private void IslamicStudiesButton_Click(object sender, RoutedEventArgs e)
        {
            category = "Islamic Studies";
            Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
            r1cs.Show();
            this.Hide();

        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            category = "History";
            Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
            r1cs.Show();
            this.Hide();
        }

        private void LiteratureButton_Click(object sender, RoutedEventArgs e)
        {
            category = "Literature";
            Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
            r1cs.Show();
            this.Hide();
        }

        private void EntertainmentButton_Click(object sender, RoutedEventArgs e)
        {
            category = "Entertainment";
            Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
            r1cs.Show();
            this.Hide();
        }

        private void SportsButton_Click(object sender, RoutedEventArgs e)
        {
            category = "Sports";
            Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
            r1cs.Show();
            this.Hide();
        }

        private void GeographyButton_Click(object sender, RoutedEventArgs e)
        {

            category = "Geography";
            Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
            r1cs.Show();
            this.Hide();
        }

        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {
            int num = random.Next(7 + 1);
            category = String.Empty;
            if (num == 1)
            {
                category = "General Knowledge";
                Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();

            }
            if (num == 2)
            {
                category = "Islamic Studies";
                Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 3)
            {
                category = "History";
                Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 4)
            {
                category = "Sports";
                Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 5)
            {
                category = "Entertainment";
                Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 6)
            {
                category = "Geography";
                Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }
            if (num == 7)
            {
                category = "Literature";
                Round3Form r1cs = new Round3Form(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1, generallistround2, category);
                r1cs.Show();
                this.Hide();
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mm = new MainMenu(generalknowledgeround1, literatureround1, islamicstudiesround1, sportsround1, geographyround1, historyround1, entertainmentround1,generallistround2);
            this.Hide();
            mm.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
