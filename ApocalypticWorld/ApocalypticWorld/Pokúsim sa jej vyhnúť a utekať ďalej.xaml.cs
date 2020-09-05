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
    public partial class Pokúsim_sa_jej_vyhnúť_a_utekať_ďalej : ContentPage
    {
        public Pokúsim_sa_jej_vyhnúť_a_utekať_ďalej()
        {
            InitializeComponent();
        }
        private void VSSKMD_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Join1());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}