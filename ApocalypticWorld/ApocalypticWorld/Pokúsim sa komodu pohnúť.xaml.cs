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
    public partial class Pokúsim_sa_komodu_pohnúť : ContentPage
    {
        public Pokúsim_sa_komodu_pohnúť()
        {
            InitializeComponent();
        }
        private void ZUD_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Začnem_utekať_ďalej());
        }
        private void SSCSTS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Spýtam_sa_čo_sa_tu_stalo());
        }
        private void SMP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Skúsim_mu_pomôcť());
        }
    }
}