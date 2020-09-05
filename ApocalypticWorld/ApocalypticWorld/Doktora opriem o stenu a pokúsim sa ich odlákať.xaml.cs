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
    public partial class Doktora_opriem_o_stenu_a_pokúsim_sa_ich_odlákať : ContentPage
    {
        public Doktora_opriem_o_stenu_a_pokúsim_sa_ich_odlákať()
        {
            InitializeComponent();
        }
        private void PZM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Preč_z_mesta());
        }
        private void ZR_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Za_rodinou());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}