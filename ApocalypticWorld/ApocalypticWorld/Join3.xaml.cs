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
    public partial class Join3 : ContentPage
    {
        public Join3()
        {
            InitializeComponent();
        }
        private void P_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nikto_neprežije());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}