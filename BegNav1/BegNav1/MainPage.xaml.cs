using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BegNav1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Button button = new Button
            //{
            //    Text = "Navigate!",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};
            //button.Clicked += async (sender, args) =>
            //{
            //    await Navigation.PushAsync(new Page1());
            //};
            //Content = button;

            //ImageButton image = new ImageButton
            //{
            //    VerticalOptions = LayoutOptions.Center,
            //    HorizontalOptions = LayoutOptions.Center,

            //    Source = ("broot.png")
            //};            //image.Clicked += async (sender, args) =>
            //{
            //    await Navigation.PushAsync(new Page1());
            //};
            //Content = image;

            //Creating TapGestureRecognizers
            var tapImage = new TapGestureRecognizer();
            //Binding events
            tapImage.Tapped += tapImage_Tapped;
            //Associating tap events to the image buttons
            img.GestureRecognizers.Add(tapImage);
        }
        void tapImage_Tapped(object sender, EventArgs e)
        {
            var page = new Page1();
            NavigationPage.SetBackButtonTitle(page, "Back");
            // handle the tap
            Navigation.PushAsync(page);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page11());
        }
        //private async void ImageButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Page1());
        //}
    }
}
