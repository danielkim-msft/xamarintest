using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.AppCenter.Crashes;

namespace xamarintest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception exception)
            {
                var properties = new Dictionary<string, string> {
                    { "Category", "Music" },
                    { "Wifi", "On" }
                  };
                Crashes.TrackError(exception, properties);
            }
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }
    }
}
