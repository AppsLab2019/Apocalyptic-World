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
    public partial class Obídeme_ju : ContentPage
    {
        public Obídeme_ju()
        {
            InitializeComponent();
        }
        private void IIH_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Join3());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}