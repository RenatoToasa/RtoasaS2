﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RtoasaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string contrasena)
        {
            InitializeComponent();
            lblUsuario.Text ="El usuario conectado es "+ usuario +" la contrasena es "+ contrasena;
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double nota = Convert.ToDouble(txtNota.Text);

            if (nota >= 7)
            {

                DisplayAlert("Mensaje de alerta", "Tu nombre es " + nombre + "\nTu apellido es " + apellido + " \nAPROBASTE con " + nota, "Cerrar");
            }
            else
            {
                DisplayAlert("Mensaje de alerta", "Tu nombre es " + nombre + "Tu apellido es " + apellido + " Reprobaste con "+nota, "Cerrar");

            }

        }
    }
}