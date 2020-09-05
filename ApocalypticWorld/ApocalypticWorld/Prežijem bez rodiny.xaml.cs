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
    public partial class Prežijem_bez_rodiny : ContentPage
    {
        public Prežijem_bez_rodiny()
        {
            InitializeComponent();
        }
        private void K_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Koniec1());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}