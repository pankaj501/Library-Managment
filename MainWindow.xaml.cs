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

namespace FinalProjectGroup11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindData();
        }

        void BindData()
        {
            Library.AddData();
            mediaList.ItemsSource = Library.media;
            nameList.ItemsSource = Library.member;   
        }

        private void UpdateGrid()
        {
            mediaList.ItemsSource = null;
            mediaList.ItemsSource = Library.media;
        }
        private void LendMedia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (((Media)mediaList.SelectedItem).Avalability)
                {
                    
                    ((Media)mediaList.SelectedItem).Borrower = ((LibraryMember)nameList.SelectedItem).Name;
                    ((Media)mediaList.SelectedItem).Avalability = false;
                    MessageBox.Show(((Media)mediaList.SelectedItem).Title + " has been lent to " + ((LibraryMember)nameList.SelectedItem).Name);
                    UpdateGrid();
                }
                else
                    MessageBox.Show("Media is currently not available");
            }
            catch(Exception ef)
            {
                MessageBox.Show("Please select the borrower and media then click to lent media");
            }
        }

        private void ReturnMedia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!((Media)mediaList.SelectedItem).Avalability && ((Media)mediaList.SelectedItem).Borrower == ((LibraryMember)nameList.SelectedItem).Name)
                {
                    ((Media)mediaList.SelectedItem).Avalability = true;
                    MessageBox.Show(((Media)mediaList.SelectedItem).Title + " has been returned by " + ((LibraryMember)nameList.SelectedItem).Name);
                    ((Media)mediaList.SelectedItem).Borrower = null;
                    UpdateGrid();
                }
                else if (!((Media)mediaList.SelectedItem).Avalability && ((Media)mediaList.SelectedItem).Borrower != ((LibraryMember)nameList.SelectedItem).Name)
                    MessageBox.Show("Media Item is Currently Lent to " + ((Media)mediaList.SelectedItem).Borrower);
                else if (((Media)mediaList.SelectedItem).Avalability)
                    MessageBox.Show(" Media item ");
            }
            catch(Exception ex)
            {
               MessageBox.Show(" Please select the media and Borrower to return media ");
               
            }
        }

        
    }
}
