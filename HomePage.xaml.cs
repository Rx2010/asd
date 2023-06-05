using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF2_443_Q3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {


        public HomePage()
        {
            InitializeComponent();

        }

        private void login_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void cntrol_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlPage());

        }

        private void gallrey_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GalleryPage());

        }

        private void close_btn_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}