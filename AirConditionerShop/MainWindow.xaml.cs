using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
using Microsoft.IdentityModel.Tokens;
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
        public StaffMember Member { get; set; } = null;

        private AirConService _airService = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDaTaInGrid();
            Wellcome.Content = "Hello, " + Member.FullName;
            if (Member.Role == 2) 
            { 
                CreateButton.IsEnabled = false;
                UpdateButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
        }

        private void FillDaTaInGrid()
        {
            // Xoá cái cũ đi để khi new hay update thì sẽ set data mới
            AirConDataGrid.ItemsSource = null;
            AirConDataGrid.ItemsSource = _airService.GetAllCons();

        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detailWindow = new();
            detailWindow.ShowDialog();

            FillDaTaInGrid();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // trả về null nếu k select cái lưới, nếu select nó sẽ trả về object

            //AirConditioner selected = (AirConditioner) AirConDataGrid.SelectedItem; // cách này nếu bị Exception thì phải bắt, còn biến dưới là k đc sẽ gán bằng null;

            AirConditioner selected = AirConDataGrid.SelectedItem as AirConditioner;
            if(selected == null) 
            {
                MessageBox.Show("Please select a row/ an air conditioner before editting!", "Select a row!",MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            DetailWindow detailWindow = new();
            detailWindow.EditedAirCon = selected;
            detailWindow.ShowDialog();

            FillDaTaInGrid();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner selected = AirConDataGrid.SelectedItem as AirConditioner;
            if (selected == null)
            {
                MessageBox.Show("Please select a row/ an air conditioner before deleting!", "Select a row!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            MessageBoxResult answer = MessageBox.Show("Do you really want to delete?", "Comfirm?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.No) {
                return;
            }

            _airService.DeleteCon(
                selected);

            FillDaTaInGrid();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            AirConDataGrid.ItemsSource = null;
            AirConDataGrid.ItemsSource = _airService.SearchByName(SearchText.Text);
            SearchText.Text = "";
        }
    }
}