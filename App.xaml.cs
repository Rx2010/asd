using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF2_443_Q3
{
    public partial class App : Application
    {
        static UserOperation db;

        // Create the database connection as a singleton.
        public static UserOperation UserSQLite
        {
            get
            {
                if (db == null)
                {
                    db = new UserOperation(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NumberCodeOpreration.db3"));
                }
                return db;
            }
        }
       
         public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
