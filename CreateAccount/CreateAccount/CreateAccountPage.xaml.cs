using Xamarin.Forms;

namespace CreateAccount
{
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            Title = "Create Account";
            InitializeComponent();
        }

		void button_action(object sender, System.EventArgs e)
		{
			//Navigation.PushAsync(new Video());
		}

		void saveButton_action(object sender, System.EventArgs e)
		{
			DisplayAlert("Navigation Page", "Save button clicked", "Ok");
		}


    }
}


