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
    public partial class Odmietnem_jeho_pomoc : ContentPage
    {
        public Odmietnem_jeho_pomoc()
        {
            InitializeComponent();
        }
        private void ZA_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Zavolám_Ashley());
        }
        private void OVD_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ostanem_v_dome());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}