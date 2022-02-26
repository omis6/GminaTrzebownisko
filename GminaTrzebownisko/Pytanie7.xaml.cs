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
    public partial class Pytanie7 : ContentPage
    {
        public Pytanie7()
        {
            InitializeComponent();
            var assembly = typeof(Pytanie7);

            zacz.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.zaczern_kos.jpg", assembly);
        }
        private async void Pytanie_7_1_Clicked(object sender, EventArgs e)
        {
            Pytanie_7_1.BackgroundColor = Color.Green;
            DependencyService.Get<IZarzadzanieWynikami>().zwieksz();
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie8());

        }
        private async void Pytanie_7_2_Clicked(object sender, EventArgs e)
        {
            Pytanie_7_2.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie8());
        }
        private async void Pytanie_7_3_Clicked(object sender, EventArgs e)
        {

            Pytanie_7_3.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie8());
        }
        private async void Pytanie_7_4_Clicked(object sender, EventArgs e)
        {

            Pytanie_7_4.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie8());
        }
    }
}