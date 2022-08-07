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

namespace ISELC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CallMainLogin();            
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        public void CallMainLogin()
        {
            Login.MainLogin mainLogin = new Login.MainLogin(this);
            PanelMainPanel.Children.Clear();
            PanelMainPanel.Children.Add(mainLogin);
        }

        public void CallMainApp()
        {
            Main_App.MainApp mainApp = new Main_App.MainApp();
            PanelMainPanel.Children.Clear();
            PanelMainPanel.Children.Add(mainApp);
        }

        public void CloseApp()
        {
            this.Close();            
        }

        public void Minimize()
        {
            
        }

    }
}
