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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<product> products;
        
        public MainWindow()
        {
            InitializeComponent();
            products = new List<product>()
            {
                new product("Рыба",10000),
                new product("Фотопарат",10000),
                new product("Ноутбук",30000),
                new product("Видеокарта",55000)
            };
            update();
        }
        public void update()
        {
            
            list1.ItemsSource = products.ToList();
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list1.ItemsSource = products.ToList();
        }

        private void tx1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var product1 = products.Where(u => u.Price > 20000).ToList();
            list1.ItemsSource = product1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
