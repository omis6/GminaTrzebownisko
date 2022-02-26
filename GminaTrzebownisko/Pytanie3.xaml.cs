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
    public partial class Pytanie3 : ContentPage
    {
        public Pytanie3()
        {
            InitializeComponent();
            var assembly = typeof(Pytanie3);

            jas.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.lotnisko.jpg", assembly);
        }
        private async void Pytanie_3_1_Clicked(object sender, EventArgs e)
        {
            Pytanie_3_1.BackgroundColor = Color.Green;
            DependencyService.Get<IZarzadzanieWynikami>().zwieksz();
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie4());

        }
        private async void Pytanie_3_2_Clicked(object sender, EventArgs e)
        {
            Pytanie_3_2.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie4());
        }
        private async void Pytanie_3_3_Clicked(object sender, EventArgs e)
        {

            Pytanie_3_3.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie4());
        }
        private async void Pytanie_3_4_Clicked(object sender, EventArgs e)
        {

            Pytanie_3_4.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie4());
        }
    }
}