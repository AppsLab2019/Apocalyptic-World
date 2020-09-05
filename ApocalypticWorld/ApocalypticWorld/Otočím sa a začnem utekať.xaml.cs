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
    public partial class Otočím_sa_a_začnem_utekať : ContentPage
    {
        public Otočím_sa_a_začnem_utekať()
        {
            InitializeComponent();
        }
        private void PSKN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pridám_sa_k_nej());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

    }
}