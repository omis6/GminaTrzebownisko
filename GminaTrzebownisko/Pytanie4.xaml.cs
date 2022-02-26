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
    public partial class Pytanie4 : ContentPage
    {
        public Pytanie4()
        {
            InitializeComponent();
            var assembly = typeof(Pytanie4);

            lod.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.lodowisko.jpg", assembly);
        }
        private async void Pytanie_4_1_Clicked(object sender, EventArgs e)
        {
            Pytanie_4_1.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie5());

        }
        private async void Pytanie_4_2_Clicked(object sender, EventArgs e)
        {
            Pytanie_4_2.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie5());
        }
        private async void Pytanie_4_3_Clicked(object sender, EventArgs e)
        {

            Pytanie_4_3.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie5());
        }
        private async void Pytanie_4_4_Clicked(object sender, EventArgs e)
        {

            Pytanie_4_4.BackgroundColor = Color.Green;
            DependencyService.Get<IZarzadzanieWynikami>().zwieksz();
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie5());
        }
    }
}