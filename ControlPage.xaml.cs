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
    public partial class ControlPage : ContentPage
    {
        public Users user;

        public ControlPage(Users users)
        {
            InitializeComponent();
            this.user = (Users)users;
       number.Text = Convert.ToString(user.Number);
            code.Text = Convert.ToString(user.Code);


        }
        public ControlPage()
        {
         InitializeComponent();

        }


        private async void create_Clicked(object sender, EventArgs e)
        {                

            if ((!string.IsNullOrEmpty(number.Text)) && (!string.IsNullOrEmpty(code.Text)))
            {
                var user = new Users()
                {
                    Number = Convert.ToInt32(number.Text),
                    Code = Convert.ToInt32(code.Text),

                };
                await App.UserSQLite.SaveUserAsync(user);
                await DisplayAlert("Done", "number is added", "Ok");
                await Navigation.PushAsync(new LoginPage());
            }
            else
                await DisplayAlert("Error", "number is empty Or number is already existe", "Ok");
        }

        private async void update_Clicked(object sender, EventArgs e)
        {
            if (user != null)
            {
                this.user.Number = Convert.ToInt32(number.Text);
                this.user.Code = Convert.ToInt32(code.Text);



                await App.UserSQLite.SaveUserAsync(this.user);
                await Navigation.PushAsync(new LoginPage());
            }else
                await DisplayAlert("Error", "can nut update plese sing in", "Ok");



        }

        private async void delete_Clicked(object sender, EventArgs e)
        {
            if (user != null)
            {
                await App.UserSQLite.DeleteUserAsync(this.user);
                await Navigation.PopToRootAsync();

            }else
                await DisplayAlert("Error", "can nut delet plase sing in", "Ok");



        }

        private void back_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}