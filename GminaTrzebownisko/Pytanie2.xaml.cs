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
    public partial class Pytanie2 : ContentPage
    {
        public Pytanie2()
        {
            InitializeComponent();
            var assembly = typeof(Pytanie2);

            lak.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.palac.JPG", assembly);
        }
        private async void Pytanie_2_1_Clicked(object sender, EventArgs e)
        {
            Pytanie_2_1.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie3());

        }
        private async void Pytanie_2_2_Clicked(object sender, EventArgs e)
        {

            Pytanie_2_2.BackgroundColor = Color.Green;
            DependencyService.Get<IZarzadzanieWynikami>().zwieksz();
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie3());
        }
        private async void Pytanie_2_3_Clicked(object sender, EventArgs e)
        {

            Pytanie_2_3.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie3());
        }
        private async void Pytanie_2_4_Clicked(object sender, EventArgs e)
        {

            Pytanie_2_4.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie3());
        }
    }
}