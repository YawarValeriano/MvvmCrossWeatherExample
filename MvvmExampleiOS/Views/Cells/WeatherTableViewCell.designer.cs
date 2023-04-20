// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmExampleiOS.Views.Cells
{
	[Register ("WeatherTableViewCell")]
	partial class WeatherTableViewCell
	{
		[Outlet]
		UIKit.UIView BackgroundView { get; set; }

		[Outlet]
		UIKit.UILabel cityNameLabel { get; set; }

		[Outlet]
		UIKit.UILabel CountryLabel { get; set; }

		[Outlet]
		UIKit.UILabel MaxTempLabel { get; set; }

		[Outlet]
		UIKit.UILabel MinTempLabel { get; set; }

		[Outlet]
		UIKit.UILabel TemperatureLabel { get; set; }

		[Outlet]
		UIKit.UILabel WeatherLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BackgroundView != null) {
				BackgroundView.Dispose ();
				BackgroundView = null;
			}

			if (cityNameLabel != null) {
				cityNameLabel.Dispose ();
				cityNameLabel = null;
			}

			if (CountryLabel != null) {
				CountryLabel.Dispose ();
				CountryLabel = null;
			}

			if (WeatherLabel != null) {
				WeatherLabel.Dispose ();
				WeatherLabel = null;
			}

			if (TemperatureLabel != null) {
				TemperatureLabel.Dispose ();
				TemperatureLabel = null;
			}

			if (MinTempLabel != null) {
				MinTempLabel.Dispose ();
				MinTempLabel = null;
			}

			if (MaxTempLabel != null) {
				MaxTempLabel.Dispose ();
				MaxTempLabel = null;
			}
		}
	}
}
