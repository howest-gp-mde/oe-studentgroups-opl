﻿using FreshMvvm;
using Mde.ClassGroupsOrganizer.Pages;
using Mde.ClassGroupsOrganizer.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.ClassGroupsOrganizer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = 
                new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());
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
