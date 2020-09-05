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
    public partial class Začnem_kričať_o_pomoc : ContentPage
    {
        public Začnem_kričať_o_pomoc()
        {
            InitializeComponent();
        }
        private void OJP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Odmietnem_jeho_pomoc());
        }
        private void PSN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pôjdem_s_ním());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}