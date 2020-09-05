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
    public partial class Zastrelím_ju : ContentPage
    {
        public Zastrelím_ju()
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