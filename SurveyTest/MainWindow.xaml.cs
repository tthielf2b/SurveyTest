using GalaSoft.MvvmLight.Ioc;
using SurveyTest.ViewModel;
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

namespace SurveyTest
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

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

        public void NextPage(int i)
        {
            switch (i)
            {
                case (0):
                    Page1View.Visibility = Visibility.Hidden;
                    //Page2View.Visibility = Visibility.Visible;
                    break;
                default:
                    MessageBox.Show("Error Switching Pages");
                    break;
            }
        }
    }
}
