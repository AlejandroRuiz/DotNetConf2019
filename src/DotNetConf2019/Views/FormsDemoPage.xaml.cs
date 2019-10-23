using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DotNetConf2019.Views
{
    public partial class FormsDemoPage : ContentPage
    {
        public FormsDemoPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
        }
    }
}
