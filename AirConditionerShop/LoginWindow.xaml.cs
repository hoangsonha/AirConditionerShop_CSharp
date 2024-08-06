using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
using Microsoft.IdentityModel.Tokens;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private MemberService _memberService = new();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            if (EmailText.Text.Trim().IsNullOrEmpty())
            {
                MessageBox.Show("Please input your email address!", "Wrong credentials!", MessageBoxButton.OK, MessageBoxImage.Error);
            } else if(PasswordText.Text.Trim().IsNullOrEmpty())
                {
                MessageBox.Show("Please input your password!", "Wrong credentials!", MessageBoxButton.OK, MessageBoxImage.Error);
            } else
            {
                StaffMember? member = _memberService.checkLogin(EmailText.Text, PasswordText.Text);
                if (member != null)
                {
                    if (member.Role == 1 || member.Role == 2)
                    {
                        // tạo ra đối tường màn hình Main
                        MainWindow main = new();
                        main.Member = member;
                        main.Show();
                        
                        // show() là sẽ new ra cửa sổ mới nên cứ bấm là new
                        this.Hide();
                        // ẩn màn hình login đi
                    }
                    else 
                        MessageBox.Show("Your role is not support!", "Wrong credentials!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                    MessageBox.Show("Invalid email or password!", "Access denied!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
      
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
