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
    public partial class Page9 : ContentPage
    {
        public Page9()
        {
            InitializeComponent();
        }

        private void Button_Clicked9(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked99(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page10());
        }
    }
}