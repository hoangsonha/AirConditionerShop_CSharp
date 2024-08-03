using AirConditionerShop.BLL.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AirConditionerShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // chuẩn là khai báo biến interface = new implêmnt

        private AirConService _airService = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDaTaInGrid();
        }

        private void FillDaTaInGrid()
        {
            // Xoá cái cũ đi để khi new hay update thì sẽ set data mới
            AirConDataGrid.ItemsSource = null;
            AirConDataGrid.ItemsSource = _airService.GetAllCons();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detailWindow = new();
            detailWindow.ShowDialog();

            FillDaTaInGrid();
        }
    }
}