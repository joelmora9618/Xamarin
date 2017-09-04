using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xappia.View;

namespace Xappia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnCargarTarea_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CargarTarea());
        }

        async private void btnListaTareas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaTareas());
        }
    }
}
