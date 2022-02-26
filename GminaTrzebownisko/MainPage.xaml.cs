using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GminaTrzebownisko
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);

            Logo.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.logo.png", assembly);
        }
        private void loginButton_Clicked(object sender, EventArgs e)
        {
            bool nazwaGracza = string.IsNullOrEmpty(nazwa_gracza.Text);
            
            if(nazwaGracza == false)
            {
                DependencyService.Get<IZarzadzanieUzytkownikami>().setname(nazwa_gracza.Text);
                Navigation.PushModalAsync(new Pytanie1());
            }
            else
            { 
                string popraw = "Nie wprowadziłeś nazwy gracza!";
                Upomnienie.Text = popraw;
            }
        }
    }
}
