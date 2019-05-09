using System;
using System.Collections.Generic;
using HelloXamarin.ViewModels;
using Xamarin.Forms;

namespace HelloXamarin.Views
{
    public partial class ThirdPage : ContentPage
    {
        ThirdPageViewModel viewModel = new ThirdPageViewModel();

        public ThirdPage()
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }
    }
}
