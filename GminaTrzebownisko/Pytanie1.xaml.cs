using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GminaTrzebownisko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pytanie1 : ContentPage
    {
        public Pytanie1()
        {
            InitializeComponent();
            var assembly = typeof(Pytanie1);

            Strona.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.strona.jpg", assembly);
        }
        private async void Pytanie_1_1_Clicked(object sender, EventArgs e)
        {
            Pytanie_1_1.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie2());
            
        }
        private async void Pytanie_1_2_Clicked(object sender, EventArgs e)
        {

            Pytanie_1_2.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie2());
        }
        private async void Pytanie_1_3_Clicked(object sender, EventArgs e)
        {

            Pytanie_1_3.BackgroundColor = Color.Red;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie2());
        }
        private async void Pytanie_1_4_Clicked(object sender, EventArgs e)
        {
            Pytanie_1_4.BackgroundColor = Color.Green;
            await Task.Delay(800);
            await Navigation.PushModalAsync(new Pytanie2());
        }
    }
}