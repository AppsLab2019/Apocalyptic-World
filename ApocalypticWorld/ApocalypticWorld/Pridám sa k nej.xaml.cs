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
    public partial class Pridám_sa_k_nej : ContentPage
    {
        public Pridám_sa_k_nej()
        {
            InitializeComponent();
        }
        private void OJ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Obídeme_ju());
        }
        private void PD_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pôjdeme_ďalej());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}