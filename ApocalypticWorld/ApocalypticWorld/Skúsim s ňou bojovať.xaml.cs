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
    public partial class Skúsim_s_ňou_bojovať : ContentPage
    {
        public Skúsim_s_ňou_bojovať()
        {
            InitializeComponent();
        }
        private void VSSKMD_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Join1());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}