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
    public partial class Spýtam_sa_čo_sa_tu_stalo : ContentPage
    {
        public Spýtam_sa_čo_sa_tu_stalo()
        {
            InitializeComponent();
        }
        private void OJ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Obídem_ju());
        }
        private void PCN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Prejdem_cez_ňu());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}