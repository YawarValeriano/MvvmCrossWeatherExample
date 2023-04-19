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
	[Register ("MyTableViewCell")]
	partial class MyTableViewCell
	{
		[Outlet]
		UIKit.UILabel lastNameLabel { get; set; }

		[Outlet]
		UIKit.UILabel nameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (nameLabel != null) {
				nameLabel.Dispose ();
				nameLabel = null;
			}

			if (lastNameLabel != null) {
				lastNameLabel.Dispose ();
				lastNameLabel = null;
			}
		}
	}
}
