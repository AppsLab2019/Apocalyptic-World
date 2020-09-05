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
    public partial class Skúsim_znova_naštartovať : ContentPage
    {
        public Skúsim_znova_naštartovať()
        {
            InitializeComponent();
        }
        private void NSZ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Príchod_domov());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}