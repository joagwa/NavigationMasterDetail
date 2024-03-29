﻿using MasterDetailNavigation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailNavigation.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuView : ContentPage
    {
        MainView RootPage { get => Application.Current.MainPage as MainView; }
        List<HomeMenuItem> menuItems;
        public MenuView()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            //ListViewMenu.ItemSelected += async (sender, e) =>
            //{
            //    if (e.SelectedItem == null)
            //        return;

            //    var id = (int)((HomeMenuItem)e.SelectedItem).Id;
            //    await RootPage.NavigateFromMenu(id);
            //};
        }
    }
}