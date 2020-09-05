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
    public partial class Obídem_ju : ContentPage
    {
        public Obídem_ju()
        {
            InitializeComponent();
        }
        private void PSJVAUD_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pokúsim_sa_jej_vyhnúť_a_utekať_ďalej());
        }
        private void SSNB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Skúsim_s_ňou_bojovať());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}