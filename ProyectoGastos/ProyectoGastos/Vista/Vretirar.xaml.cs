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
    public partial class Vretirar : ContentPage
    {
        public Vretirar()
        {
            InitializeComponent();
            BindingContext = new VMretirar(Navigation);
        }
    }
}