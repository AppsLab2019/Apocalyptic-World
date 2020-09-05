using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApocalypticWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nikto_neprežije : ContentPage
    {
        public Nikto_neprežije()
        {
            InitializeComponent();
        }
        private void K_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Koniec2());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}