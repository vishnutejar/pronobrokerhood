using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProNobrokerHood.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void VaidateMobileNumber(object sender, EventArgs e)
        {
            var mobilenumber = ety_mobile.Text;
            if (string.IsNullOrEmpty(mobilenumber))
            {
                DisplayAlert("Error Title", "Enter Your userName or Mobile Number", "ok");
            }
            else { 
            // check entried value is mobile or not 
            //then we need to procced wit Mobile Number and save it.
            }
        }
    }
}