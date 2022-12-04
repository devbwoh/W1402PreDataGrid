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

namespace W1402PreDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GundamViewModel GundamList = new GundamViewModel();

        public MainWindow()
        {
            InitializeComponent();

            Grid.ItemsSource = GundamList.List;

            GundamList.Add(new Gundam("건담", "RX-78-2", "연방군"));
            GundamList.Add(new Gundam("자쿠II", "MS-06", "지온군"));
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            //GundamList.Add(new Gundam("건탱크", "RX-75-4", "연방군"));

            GundamWin g = new GundamWin();
            if (g.ShowDialog() != true)
                return;

            GundamList.Add(new Gundam(g.MSName, g.MSModel, g.MSParty));
        }

        private void OnChanged(object sender, SelectionChangedEventArgs e)
        {
            Gundam g = (Gundam)Grid.SelectedItem;

            BitmapImage b = new BitmapImage(new Uri($"images/{g.Name}.jpg",
                UriKind.RelativeOrAbsolute));
            Image.Source = b;
        }
    }
}
