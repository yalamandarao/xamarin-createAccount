using Xamarin.Forms;

namespace CreateAccount
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CreateAccountPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.Red
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
