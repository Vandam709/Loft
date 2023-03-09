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

namespace ShopMag.Pages
{
    /// <summary>
    /// Логика взаимодействия для OknoProfile.xaml
    /// </summary>
    public partial class OknoProfile : Window
    {
        public OknoProfile()
        {
            InitializeComponent();
            LViewSklad.ItemsSource = AppData.Helpers.ClassConnect.user21Entities.Reservations.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
