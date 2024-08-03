using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
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

namespace AirConditionerShop
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        private AirConService _airService = new();
        private SupplierComSerivce _supplierComService = new();

        public DetailWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner airConditioner = new AirConditioner();
            airConditioner.AirConditionerId = int.Parse(AirConditionerIdTextBox.Text); // nếu key tự tăng thì k cần field ID vì hệ thống sẽ tự generate
            airConditioner.AirConditionerName = AirConditionerNameTextBox.Text;
            airConditioner.Warranty = WarrantyTextBox.Text;
            airConditioner.SoundPressureLevel = SoundPressureLevelTextBox.Text;
            airConditioner.FeatureFunction = FeatureFunctionTextBox.Text;
            airConditioner.Quantity = int.Parse(QuantityTextBox.Text);
            airConditioner.DollarPrice = double.Parse(DollarPriceTextBox.Text);
            airConditioner.SupplierId = SupplierIdComboBox.SelectedValue.ToString();

            _airService.AddCon(airConditioner);

            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataSupplierCompany();

        }

        private void FillDataSupplierCompany()
        {
            SupplierIdComboBox.ItemsSource = _supplierComService.GetAllSupplierCompanies();
            SupplierIdComboBox.DisplayMemberPath = "SupplierName";
            SupplierIdComboBox.SelectedValuePath = "SupplierId";
            
        }
    }
}
