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
using ToyShop.Components;

namespace ToyShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ToysList.ItemsSource = DbConnet.db.Toy.ToList();

        }
        
        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы не можете добавлять записи. Купите админку что бы добавит и редактировать записи." +
                "+7926246203 Сбербанк Хуаенов Ильназ В.", "Уведомление", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK);
        }

        private void ClientBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы не можете добавлять записи. Купите админку что бы добавит и редактировать записи." +
                "+7926246203 Сбербанк Хуаенов Ильназ В.", "Уведомление", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK) ;
        }

    }
}
