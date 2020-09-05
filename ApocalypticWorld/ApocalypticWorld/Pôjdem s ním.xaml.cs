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
    public partial class Pôjdem_s_ním : ContentPage
    {
        public Pôjdem_s_ním()
        {
            InitializeComponent();
        }
        private void ZJ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Zastrelím_ju());
        }
        private void ZAAPNC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Zavriem_auto_a_počkám_na_Calvina());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}