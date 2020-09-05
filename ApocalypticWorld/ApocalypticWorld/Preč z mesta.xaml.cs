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
    public partial class Preč_z_mesta : ContentPage
    {
        public Preč_z_mesta()
        {
            InitializeComponent();
        }

        private void P_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new join2());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}