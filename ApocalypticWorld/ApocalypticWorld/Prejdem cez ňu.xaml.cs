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
    public partial class Prejdem_cez_ňu : ContentPage
    {
        public Prejdem_cez_ňu()
        {
            InitializeComponent();
        }
        private void BB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Budem_bojovať());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}