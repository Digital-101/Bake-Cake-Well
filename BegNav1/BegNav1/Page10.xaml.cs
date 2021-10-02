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
    public partial class Page10 : ContentPage
    {
        public Page10()
        {
            InitializeComponent();
        }

        private void Button_Clicked10(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked101(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}