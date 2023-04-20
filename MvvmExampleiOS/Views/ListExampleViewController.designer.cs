// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmExampleiOS.Views
{
	[Register ("ListExampleViewController")]
	partial class ListExampleViewController
	{
		[Outlet]
		UIKit.UITableView dataTableView { get; set; }

		[Outlet]
		UIKit.UIButton SearchButton { get; set; }

		[Outlet]
		UIKit.UITextField SearchField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (dataTableView != null) {
				dataTableView.Dispose ();
				dataTableView = null;
			}

			if (SearchButton != null) {
				SearchButton.Dispose ();
				SearchButton = null;
			}

			if (SearchField != null) {
				SearchField.Dispose ();
				SearchField = null;
			}
		}
	}
}
