using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        
        string url= System.Configuration.ConfigurationManager.AppSettings["SERVER_API"];
        string route = "/api/iselc/user/login";

        public string status_user;


        MainLogin _mainLogin;
        public Login(MainLogin mainLogin)
        {
            InitializeComponent();
            _mainLogin = mainLogin;
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Password == "")
            {
                MessageBox.Show(" Harap Masukan Username/Password");
            }
            else
            {                
                LoginApp();
            }

        }

        public async void LoginApp()
        {
            try
            {
                var values = new Dictionary<string, string>
            {
                { "username", textUsername.Text },
                { "password",textPassword.Password},                
            };


                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(url + route, content);
                var responseString = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(responseString);

                JObject stuff = JObject.Parse(responseString);

                string status = stuff["status"].ToString();
                string message = stuff["message"].ToString();

                if (status == "Success")
                {
                    JObject data = JObject.Parse(stuff["data"].ToString());
                    status_user = data["status_user"].ToString();
                    bool status_password = ((bool)data["status_password"]);
                    MessageBox.Show(message);

                    if (status_user == "SUPER USER" && status_password == true)
                    {
                        _mainLogin._main.CallMainApp();
                    }
                    else 
                    {
                        _mainLogin._main.CallMainApp();
                    }
                   
                }
                else
                {
                    MessageBox.Show(message);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
