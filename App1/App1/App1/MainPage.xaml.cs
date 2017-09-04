using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (validateLogin(entUser, lblUser, entPass, lblPass))
            {
                 await Navigation.PushAsync(new ListaTareas());
            }
        }

        public Boolean validateLogin(Entry entUser, Label lblUser, Entry entPass, Label lblPass)
        {
            Boolean state = true;

            if (String.IsNullOrEmpty(entUser.Text))
            {
                lblUser.Text = "usuario invalido!";
                lblUser.IsVisible = true;
                state = false;
            }
            else
            {
                lblUser.IsVisible = false;
            }
            if (String.IsNullOrEmpty(entPass.Text))
            {
                lblPass.Text = "password invalido!";
                lblPass.IsVisible = true;
                state = false;
            }
            else
            {
                lblPass.IsVisible = false;
            }

            return state;
        }
    }
}
