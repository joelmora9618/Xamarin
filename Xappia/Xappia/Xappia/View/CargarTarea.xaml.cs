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
    public partial class CargarTarea : ContentPage
    {
        public CargarTarea()
        {
            InitializeComponent();
        }

        private void btnGuardar(object sender, EventArgs e)
        {
            Tarea nuevaTarea = new Tarea()
            {
                Nombre = entNombre.Text,
                Fecha = fechaLimiteDatePicker.Date,
                Hora = horaLimiteTimePicker.Time,
                Completada = false
            };
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.RutaDB))
            {
                connection.CreateTable<Tarea>();

                var resultado = connection.Insert(nuevaTarea);

                if (resultado > 0)
                {
                    DisplayAlert("Exito", "El elemento se guardo", "OK");
                }
                else
                {
                    DisplayAlert("Error", "Intente de nuevo", "OK");
                }
            }
        }
    }
}