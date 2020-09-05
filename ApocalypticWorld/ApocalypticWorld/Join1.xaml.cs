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
    public partial class Join1 : ContentPage
    {
        public Join1()
        {
            InitializeComponent();
        }
        private void P_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Prežijem_bez_rodiny());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}