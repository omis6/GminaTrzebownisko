using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GminaTrzebownisko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pytanie6 : ContentPage
    {
        public Pytanie6()
        {
            InitializeComponent();
            var assembly = typeof(Pytanie6);

            mo.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.most.jpg", assembly);
        }
        private async void Pytanie_6_1_Clicked(object sender, EventArgs e)
        {
            Pytanie_6_1.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie7());
        }
        private async void Pytanie_6_2_Clicked(object sender, EventArgs e)
        {
            Pytanie_6_2.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie7());
        }
        private async void Pytanie_6_3_Clicked(object sender, EventArgs e)
        {

            Pytanie_6_3.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie7());
        }
        private async void Pytanie_6_4_Clicked(object sender, EventArgs e)
        {
            Pytanie_6_4.BackgroundColor = Color.Green;
            DependencyService.Get<IZarzadzanieWynikami>().zwieksz();
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie7());
        }
    }
}