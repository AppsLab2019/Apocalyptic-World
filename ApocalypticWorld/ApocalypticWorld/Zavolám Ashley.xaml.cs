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
    public partial class Zavolám_Ashley : ContentPage
    {
        public Zavolám_Ashley()
        {
            InitializeComponent();
        }
        private void ZJSS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Zoberiem_ju_so_sebou());
        }
        private void OUN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ostanem_u_nej());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}