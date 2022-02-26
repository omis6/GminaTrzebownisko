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
    public partial class Pytanie8 : ContentPage
    {
        public Pytanie8()
        {
            InitializeComponent();
            var assembly = typeof(Pytanie8);

            kl.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.kladka.jpg", assembly);
        }
        private async void Pytanie_8_1_Clicked(object sender, EventArgs e)
        {
            Pytanie_8_1.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie10());

        }
        private async void Pytanie_8_2_Clicked(object sender, EventArgs e)
        {
            Pytanie_8_2.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie10());
        }
        private async void Pytanie_8_3_Clicked(object sender, EventArgs e)
        {

            Pytanie_8_3.BackgroundColor = Color.Green;
            DependencyService.Get<IZarzadzanieWynikami>().zwieksz();
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie10());
        }
        private async void Pytanie_8_4_Clicked(object sender, EventArgs e)
        {

            Pytanie_8_4.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie10());
        }
    }
}