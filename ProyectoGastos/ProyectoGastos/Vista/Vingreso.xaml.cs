﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoGastos.VistaModelo;

namespace ProyectoGastos.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vingreso : ContentPage
    {
        public Vingreso()
        {
            InitializeComponent();
            BindingContext = new VMingresar(Navigation);
        }
    }
}