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
    public partial class Chvíľu_si_ešte_oddýchnem : ContentPage
    {
        public Chvíľu_si_ešte_oddýchnem()
        {
            InitializeComponent();
        }
        private void OSAZU_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Otočím_sa_a_začnem_utekať());
        }
        private void ZNN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Zakričím_na_ňu());

        }
        private void button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}