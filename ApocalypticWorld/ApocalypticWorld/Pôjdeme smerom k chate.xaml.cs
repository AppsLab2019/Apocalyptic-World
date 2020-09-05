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
    public partial class Pôjdeme_smerom_k_chate : ContentPage
    {
        public Pôjdeme_smerom_k_chate()
        {
            InitializeComponent();
        }
        private void PSKN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new join5());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}