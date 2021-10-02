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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }


        private void Button_Clicked0(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Button_Clicked_Remove(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}