using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo_App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Search(object sender, EventArgs e)
        {
            if (activityIndicator.IsRunning == false)
            {
                activityIndicator.IsRunning = true;
            }
            else
            {
                activityIndicator.IsRunning = false;
            }
            //activityIndicator.IsRunning = true;
            //this.DisplayAlert("hej","lkjh","Close");
        }
    }
}
