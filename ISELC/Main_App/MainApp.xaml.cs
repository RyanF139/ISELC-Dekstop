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

namespace ISELC.Main_App
{
    /// <summary>
    /// Interaction logic for MainApp.xaml
    /// </summary>
    public partial class MainApp : UserControl
    {
        public MainApp()
        {
            InitializeComponent();
            CallMenuBar();
        }

        public void CallMenuBar()
        {
            MenuBar menuBar = new MenuBar();
            PanelMenuBar.Children.Clear();
            PanelMenuBar.Children.Add(menuBar);
        }
    }
}
