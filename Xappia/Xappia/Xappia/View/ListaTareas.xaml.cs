using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xappia.Model;

namespace Xappia.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaTareas : ContentPage
    {
        public ListaTareas()
        {
            InitializeComponent();

            var botonNuevo = new ToolbarItem()
            {
                Text = "+"
            };

            botonNuevo.Clicked += BotonNuevo_Clicked;
            ToolbarItems.Add(botonNuevo);
        }
        async private void BotonNuevo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CargarTarea());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.RutaDB))
            {
                List<Tarea> listaTareas;
                listaTareas = connection.Table<Tarea>().Where(t => t.Completada == false).ToList();

                lvTareas.ItemsSource = listaTareas;
            }
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.RutaDB))
            {
                var tareaAcompletar = (sender as MenuItem).CommandParameter as Tarea;
                tareaAcompletar.Completada = true;

                connection.Update(tareaAcompletar);

                List<Tarea> listaTareasFiltrada;
                listaTareasFiltrada = connection.Table<Tarea>().Where(t => t.Completada == false).ToList();
                lvTareas.ItemsSource = listaTareasFiltrada;
            }
        }
    }
}