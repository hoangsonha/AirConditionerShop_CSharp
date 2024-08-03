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
        public AirConditioner EditedAirCon { get; set; } = null;  // flag variable to identify which screen is update or create,

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

            if(EditedAirCon == null)
            
                _airService.AddCon(airConditioner);
            
             else 
                _airService.UpdateCon(airConditioner);
            
            
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataSupplierCompany();
            FillElement(EditedAirCon);

            // change title screen for update or create

            if(EditedAirCon != null)
                DetailWindowMode.Content = "Cập nhật thông tin máy lạnh"; 
            else
                DetailWindowMode.Content = "Tạo mới thông tin máy lạnh";
        }

        private void FillDataSupplierCompany()
        {
            SupplierIdComboBox.ItemsSource = _supplierComService.GetAllSupplierCompanies();
            SupplierIdComboBox.DisplayMemberPath = "SupplierName";
            SupplierIdComboBox.SelectedValuePath = "SupplierId";
            
        }

        // this method fill data for update
        private void FillElement(AirConditioner x)
        {
            if (x == null) return;
            AirConditionerIdTextBox.Text = x.AirConditionerId.ToString();

            // disable input ID

            AirConditionerIdTextBox.IsEnabled = false;

            AirConditionerNameTextBox.Text = x.AirConditionerName;
            WarrantyTextBox.Text = x.Warranty;
            SoundPressureLevelTextBox.Text = x.SoundPressureLevel; 
            FeatureFunctionTextBox.Text = x.FeatureFunction;
            QuantityTextBox.Text = x.Quantity.ToString();
            DollarPriceTextBox.Text = x.Quantity.ToString();
            SupplierIdComboBox.SelectedValue = x.SupplierId;

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            // TODO: hỏi rằng có muốn save hay k trước khi đóng
        }
    }
}
