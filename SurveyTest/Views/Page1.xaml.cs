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

namespace SurveyTest.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {

        public Page1()
        {
            InitializeComponent();
            
        }

        private void No1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Thank You For Your Time!");
           
            Application.Current.Shutdown();
        }

        private void Yes1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow n = Application.Current.MainWindow as MainWindow;
            n.NextPage(0);
        }
    }
}
