using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BegNav1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Button_Clicked6(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked66(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }
    }
}