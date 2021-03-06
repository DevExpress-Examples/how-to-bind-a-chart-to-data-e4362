﻿using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace BindChart {

    public sealed partial class MainPage : Page {

        public MainPage() {
            this.InitializeComponent();
            DataContext = new ViewModel() {
                Start = 10000,
                Count = 50000,
                Step = TimeSpan.FromHours(3),
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }
    }
}
