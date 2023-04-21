using System;
using Foundation;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmExampleiOS.Views.Cells;
using UIKit;

namespace MvvmExampleiOS.Views.Source
{
	public class WeatherDataSource: MvxTableViewSource
    {
		public WeatherDataSource(UITableView tableView) : base(tableView)
		{
            // Register cell for reuse
            tableView.RegisterNibForCellReuse(WeatherTableViewCell.Nib, WeatherTableViewCell.Key);
            DeselectAutomatically = true;
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var cell = this.TableView.DequeueReusableCell(WeatherTableViewCell.Key, indexPath) as WeatherTableViewCell;
            return cell;
        }
    }
}

