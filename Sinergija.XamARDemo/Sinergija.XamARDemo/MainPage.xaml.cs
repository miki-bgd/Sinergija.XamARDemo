using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamAR.Core.Models.Geolocation;
using Xamarin.Forms;

namespace Sinergija.XamARDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            var location = new Location(44.823052, 20.447704);
            string title = "The Victor";
            var poiObject = XamAR.World.Instance.AddPointOfInterest(location, title);

            // When location is too far away from current location,
            // set it closer to the device (direction is preserved).
            var distance = new XamAR.Core.Models.Distance.FixedDistance(2);
            poiObject.DistanceOverride = distance;
        }
    }
}
