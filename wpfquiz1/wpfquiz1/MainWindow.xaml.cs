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
using WinForms= System.Windows.Forms;
namespace wpfquiz1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ChooseDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog folderDlg = new WinForms.FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            WinForms.DialogResult result = folderDlg.ShowDialog();
            if (result == WinForms.DialogResult.OK)
            {
                    String chosenText = folderDlg.SelectedPath;
                    //MainMenuForm mm = new MainMenuForm(chosenText);
                    MainMenu mm = new MainMenu(chosenText);
                //MainMenuForm mmf = new MainMenuForm(generalknowledge,literature,islamicstudies,sports,geography,history,entertainment);
                this.Hide();
                    mm.Show();
                    //mmf.Show();
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            else
            {
                MessageBox.Show("Faced Error");
            }

        }
    }
}
