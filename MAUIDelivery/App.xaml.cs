﻿using MAUIDelivery.Views;

namespace MAUIDelivery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}