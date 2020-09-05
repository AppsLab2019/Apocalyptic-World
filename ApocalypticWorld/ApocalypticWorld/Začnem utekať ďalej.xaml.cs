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
    public partial class Začnem_utekať_ďalej : ContentPage
    {
        public Začnem_utekať_ďalej()
        {
            InitializeComponent();
        }
        private void SZN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Skúsim_znova_naštartovať());
        }
        private void ZVDAPSS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Zavriem_všetky_dvere_a_pokúsim_sa_schovať());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}