using System;
using System.Linq;
using MonoTouch.UIKit;
using Xamarin.Themes;

namespace ThemeSample
{
	public class TableViewController : UITableViewController
	{
		public TableViewController ()
		{
			this.Title = "TableView";
			this.TabBarItem = new UITabBarItem ("TableView", new UIImage ("tableIcon.png"), 0);
		}
		
		public Track[] Tracks
		{
			get;
			set;
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Tracks = SampleTracks.GetTracks().ToArray();
			BlackLeatherTheme.Apply (this);
			TableView.DataSource = new DataSource (this);

		}
		class DataSource : UITableViewDataSource
		{
			TableViewController Parent;
			public DataSource(TableViewController parent)
			{
				Parent = parent;
			}
			#region implemented abstract members of UITableViewDataSource

			public override int RowsInSection (UITableView tableView, int section)
			{
				return Parent.Tracks.Length;
			}
			string cellKey = "themedCell";
			public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell (cellKey);
				if (cell == null) {
					cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellKey);
					BlackLeatherTheme.Apply (cell);
				}
				
				Track track = this.Parent.Tracks[indexPath.Row];
				
				cell.TextLabel.Text = track.TrackName;
				cell.DetailTextLabel.Text = track.ArtistName;
				cell.ImageView.Image = track.AlbumImage;

				return cell;
			}

			#endregion


		}
	}
}

