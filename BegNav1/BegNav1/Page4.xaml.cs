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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked44(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }
    }
}