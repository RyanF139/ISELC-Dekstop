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

namespace ISELC.Login
{
    /// <summary>
    /// Interaction logic for MainLogin.xaml
    /// </summary>
    public partial class MainLogin : UserControl
    {

        public MainWindow _main;
        public MainLogin(MainWindow main)
        {
            InitializeComponent();
            _main = main;

            //CallCreateS_U();
            CallLogin();
        }
        

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Close application ?", "Application Message", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _main.CloseApp();
            }
            
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void CallCreateS_U()
        {
            Create_Super_User create_Super_User = new Create_Super_User();
            PanelLogin.Children.Clear();
            PanelLogin.Children.Add(create_Super_User);
        }

        public void CallLogin()
        {
            Login login = new Login();
            PanelLogin.Children.Clear();
            PanelLogin.Children.Add(login);
        }
    }
}
