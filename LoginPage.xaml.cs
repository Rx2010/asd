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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void login_Clicked(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(number.Text) && !string.IsNullOrEmpty(code.Text))
                {
                    var user = await App.UserSQLite.GetnumberAsync(Convert.ToInt16(number.Text), Convert.ToInt16(code.Text));
                    if (user != null)
                    {
                        await Navigation.PushAsync(new FinalPage(user));
                    }
                    else
                        await DisplayAlert("Error", "number is error", "Ok");
                }
                else
                    await DisplayAlert("Error", "number is empty", "Ok");
            }
        }



        private void home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}