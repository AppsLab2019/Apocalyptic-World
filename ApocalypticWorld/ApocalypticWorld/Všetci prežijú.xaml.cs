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
    public partial class Všetci_prežijú : ContentPage
    {
        public Všetci_prežijú()
        {
            InitializeComponent();
        }
        private void K_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Koniec3());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}