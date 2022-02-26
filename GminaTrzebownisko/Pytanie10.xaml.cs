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
    public partial class Pytanie10 : ContentPage
    {
        public Pytanie10()
        { 
            InitializeComponent();
            var assembly = typeof(Pytanie10);
            rzeszow.Source = ImageSource.FromResource("GminaTrzebownisko.Zdjecia.rzeszow.jpg", assembly);
            Wyswietl.Text = "Brawo " + DependencyService.Get<IZarzadzanieUzytkownikami>().getname() + "!";
            Wynik.Text = "Zdobyłeś " + DependencyService.Get<IZarzadzanieWynikami>().getwynik() + " punktów!";
        }
        
    }
}