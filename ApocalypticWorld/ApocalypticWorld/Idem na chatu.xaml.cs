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
    public partial class Idem_na_chatu : ContentPage
    {
        public Idem_na_chatu()
        {
            InitializeComponent();
        }
        private void P_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new join4());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}