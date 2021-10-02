﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BegNav1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_ClickedP(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
    }
}