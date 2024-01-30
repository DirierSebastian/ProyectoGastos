﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoGastos.Vista;

namespace ProyectoGastos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vingreso());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
