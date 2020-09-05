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
    public partial class Ostanem_v_dome : ContentPage
    {
        public Ostanem_v_dome()
        {
            InitializeComponent();
        }
        private void PSKC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pôjdeme_smerom_k_chate());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}