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
    public partial class Skúsim_nájsť_iný_východ : ContentPage
    {
        public Skúsim_nájsť_iný_východ()
        {
            InitializeComponent();
        }
        private void INC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Idem_na_chatu());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}