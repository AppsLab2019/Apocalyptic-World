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
    public partial class Spolu_s_doktorom_rýchlo_prejdeme_k_sanítke : ContentPage
    {
        public Spolu_s_doktorom_rýchlo_prejdeme_k_sanítke()
        {
            InitializeComponent();
        }
        private void ZR_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Za_rodinou());
        }
        private void KVZ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new K_vojenskej_základni());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}