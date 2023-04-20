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
			this.Layer.BackgroundColor = UIColor.Blue.CGColor;
			this.Layer.CornerRadius = 8;
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<WeatherTableViewCell, ListResult>();
                set.Bind(cityNameLabel).For(v => v.Text).To(m => m.Name);
                set.Apply();
            });
        }
	}
}
