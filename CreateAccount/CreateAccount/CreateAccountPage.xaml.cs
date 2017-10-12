using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CreateAccount
{
    public partial class CreateAccountPage : ContentPage
    {
        List<Member> member;

        public CreateAccountPage()
        {
            Title = "Create Account";
            member = new List<Member>();
            InitializeComponent();
        }

		void button_action(object sender, System.EventArgs e)
		{
            //Navigation.PushAsync(new Video());
		}

        public async void viewButton_action(object sender, System.EventArgs e)
        {
            await DisplayAlert("Member", member[0].FirstName + "," + member[0].MiddleName + "," + member[0].LastName + "," + member[0].DateTime, "Ok");
        }

        public void saveButton_action(object sender, System.EventArgs e)
		{
            member = new List<Member>();
            member.Add(new Member(FirstName.Text,
                                  MiddleName.Text,
                                  LastName.Text,
                                  SetDateTime(Date.Date,
                                              Time.Time.Hours, 
                                              Time.Time.Minutes,
                                              Time.Time.Seconds)
                                 ));
			DisplayAlert("Navigation Page", "Save button clicked", "Ok");
		}

        private DateTime SetDateTime(DateTime date, int hour, int minute, int seconds){
            return new DateTime(date.Year, date.Month, date.Day, hour, minute, seconds);
        }


    }
}


