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
    public partial class Zakričím_na_ňu : ContentPage
    {
        public Zakričím_na_ňu()
        {
            InitializeComponent();
        }
        private void PSIP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pokúsim_sa_ich_preraziť());
        }
        private void SNIV_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Skúsim_nájsť_iný_východ());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}