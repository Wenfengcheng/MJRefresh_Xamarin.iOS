using System;
using Foundation;
using MJRefresh;
using UIKit;

namespace Test_MJRefresh
{
    public partial class ViewController : UIViewController
    {
        public UITableView table;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.Frame = new CoreGraphics.CGRect(0, 0, 375, 667);
            this.View.AutoresizingMask = UIViewAutoresizing.All;

            UIRefreshControl control = new UIRefreshControl();
            control.TintColor = UIColor.Red;
            control.AttributedTitle = new NSAttributedString("1232142142");

            table = new UITableView();
            table.Frame = new CoreGraphics.CGRect(0, 0, 375, 667);
            table.AutoresizingMask = UIViewAutoresizing.All;
            table.DataSource = new TableDelegate();
            table.SetHeader(MJRefreshNormalHeader.HeaderWithRefreshingTarget(this, new ObjCRuntime.Selector("MySelector")));
            table.AddSubview(control);
            this.View.AddSubview(table);
            table.GetHeader().BeginRefreshing();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        [Export ("MySelector")]
        public void RefreshData()
        {
            table.ReloadData();
        }
    }

    public class TableDelegate : UITableViewDataSource
    {
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("testcell");
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, "testcell");
            cell.TextLabel.Text = "yyyyy";
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 20;
        }
    }
}
