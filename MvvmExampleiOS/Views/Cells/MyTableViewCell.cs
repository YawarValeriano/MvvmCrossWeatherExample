using System;
using Core.Models;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;

namespace MvvmExampleiOS.Views.Cells
{
	public partial class MyTableViewCell : MvxTableViewCell
    {
		public static readonly NSString Key = new NSString ("MyTableViewCell");
		public static readonly UINib Nib;

		static MyTableViewCell ()
		{
			Nib = UINib.FromName ("MyTableViewCell", NSBundle.MainBundle);
		}

		protected MyTableViewCell (IntPtr handle) : base (handle)
		{
            // Note: this .ctor should not contain any initialization logic.
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<MyTableViewCell, Person>();
                set.Bind(nameLabel).To(m => m.Name);
                set.Bind(lastNameLabel).To(m => m.LastName);
                set.Apply();
            });
        }
	}
}
