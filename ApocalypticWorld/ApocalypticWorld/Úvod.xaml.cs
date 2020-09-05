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
    public partial class Úvod : ContentPage
    {
        public Úvod()
        {
            InitializeComponent();
        }
        private void PSKP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pokúsim_sa_komodu_pohnúť());
        }
        private void CSEO_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chvíľu_si_ešte_oddýchnem());
        }
        private void ZKOP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Začnem_kričať_o_pomoc());
        }
    }
}