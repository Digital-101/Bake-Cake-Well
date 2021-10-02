using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BegNav1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page11 : ContentPage
    {
        public Page11()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var paged = new Page11();
            NavigationPage.SetHasBackButton(paged, false);
            Navigation.PopToRootAsync();
        }

        string url = "https://www.bbcgoodfood.com/recipes/raspberry-bakewell-cake";
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri(url), BrowserLaunchMode.SystemPreferred);
        }
    }
}