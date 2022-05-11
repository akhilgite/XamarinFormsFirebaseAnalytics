using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirebaseAnalytics
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            IFirebaseAnalyticsService service = DependencyService.Get<IFirebaseAnalyticsService>();
            service?.LogEvent("MyEventHere");
        }
    }
}
