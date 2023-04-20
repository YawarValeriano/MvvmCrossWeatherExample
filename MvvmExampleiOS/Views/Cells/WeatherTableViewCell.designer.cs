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
		UIKit.UILabel cityNameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (cityNameLabel != null) {
				cityNameLabel.Dispose ();
				cityNameLabel = null;
			}
		}
	}
}
