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
    public partial class Skúsim_mu_pomôcť : ContentPage
    {
        public Skúsim_mu_pomôcť()
        {
            InitializeComponent();
        }
        private void DOOSAPSIO_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Doktora_opriem_o_stenu_a_pokúsim_sa_ich_odlákať());
        }
        private void SSDRPKS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Spolu_s_doktorom_rýchlo_prejdeme_k_sanítke());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}