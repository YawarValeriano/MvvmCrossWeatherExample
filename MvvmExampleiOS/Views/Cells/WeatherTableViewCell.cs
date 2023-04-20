using System;
using Core.Models;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;

namespace MvvmExampleiOS.Views.Cells
{
	public partial class WeatherTableViewCell : MvxTableViewCell
    {
		public static readonly NSString Key = new NSString ("WeatherTableViewCell");
		public static readonly UINib Nib;

		static WeatherTableViewCell ()
		{
			Nib = UINib.FromName ("WeatherTableViewCell", NSBundle.MainBundle);
		}

		protected WeatherTableViewCell (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.

			//BackgroundView.Layer.CornerRadius = 8;
			//ContentView.Layer.CornerRadius = 8;
   //         ContentView.BackgroundColor = UIColor.Blue;

            this.DelayBind(() =>
            {
				var set = this.CreateBindingSet<WeatherTableViewCell, ListResult>();
				set.Bind(cityNameLabel).To(m => m.Name);
				set.Bind(CountryLabel).To(m => m.Sys.Country);
				set.Bind(WeatherLabel).To(m => m.Weather[0].Main);
				set.Bind(TemperatureLabel).To(m => m.Main.Temp);
				set.Bind(MinTempLabel).To(m => m.Main.TempMin);
				set.Bind(MaxTempLabel).To(m => m.Main.TempMax);
                set.Apply();
            });
        } 
	}
}
