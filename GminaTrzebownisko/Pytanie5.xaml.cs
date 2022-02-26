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
    public partial class Pytanie5 : ContentPage
    {
        public Pytanie5()
        {
            InitializeComponent();
            var assembly = typeof(Pytanie5);

            spi.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.staryspich.jpg", assembly);
        }
        private async void Pytanie_5_1_Clicked(object sender, EventArgs e)
        {
            Pytanie_5_1.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie6());

        }
        private async void Pytanie_5_2_Clicked(object sender, EventArgs e)
        {
            Pytanie_5_2.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie6());
        }
        private async void Pytanie_5_3_Clicked(object sender, EventArgs e)
        {

            Pytanie_5_3.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie6());
        }
        private async void Pytanie_5_4_Clicked(object sender, EventArgs e)
        {
            Pytanie_5_4.BackgroundColor = Color.Green;
            DependencyService.Get<IZarzadzanieWynikami>().zwieksz();
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie6());
        }

    }
}