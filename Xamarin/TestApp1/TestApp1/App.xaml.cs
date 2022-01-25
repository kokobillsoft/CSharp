﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestApp1.Services;
using TestApp1.Views;

namespace TestApp1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
