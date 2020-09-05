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
    public partial class Zavriem_auto_a_počkám_na_Calvina : ContentPage
    {
        public Zavriem_auto_a_počkám_na_Calvina()
        {
            InitializeComponent();
        }
        private void PCAP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Poviem_Calvinovi_aby_pridal());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}