using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using Aplication;
using Domain;
using Notes.Properties;
using Notes.Resources;

namespace Notes.Views
{
    /// <summary>
    /// Lógica de interacción para UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        bool success = false;
        public UserLogin()
        {
            InitializeComponent();
            this.TopBar.ConfigTopBar(this, TopBar.State.NORMAL, false, false, false);
            TxtUser.Focus();
        }
        public bool Success => success;

        private void BtnIn_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) Login();
        }

        private async void Login()
        {
            
            string userName = TxtUser.Text;
            if (userName.Length > 0)
            {
                ActivateFields(false);
                var response = await Service.instance.GetUserFromName(userName);

                if (response == null)
                {
                    MessageBoxResult res = MessageBox.Show($"El usuario: {userName} no se ha encontrado.\n¿Desea crearlo?", "Usuario no Encontrado", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes)
                    {
                        InsertUser(userName);
                    }
                    else
                    {
                        ActivateFields();
                    }
                }

                else
                {
                    Settings.Default.UserId = response.Id;
                    //Settings.Default.Save();
                    success = true;
                    Close();
                }
            }
        }

        private void ActivateFields(bool enabled = true)
        {
            TxtUser.IsEnabled = enabled;
            BtnIn.IsEnabled = enabled;
        }

        private async void InsertUser(string userName)
        {
            var response = await Service.instance.InsertUser(userName);
            if (response != null)
            {
                Settings.Default.UserId = response.Id;
                success = true;
                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            
        }


    }
}
