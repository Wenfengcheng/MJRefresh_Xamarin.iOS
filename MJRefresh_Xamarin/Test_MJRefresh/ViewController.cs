using System;
using System.Threading.Tasks;
using Foundation;
using MJRefresh;
using UIKit;

namespace Test_MJRefresh
{
    public partial class ViewController : UIViewController
    {
        public UITableView table;
        public int Count { get; set; }

        public ViewController()
        {
            
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.White;

            table = new UITableView
            {
                TableFooterView = new UIView(),
                Frame = new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height),
                DataSource = new TableDataSource(this),
                Delegate = new TableDelegate(this)
            };
            this.View.AddSubview(table);

            MJRefreshNormalHeader header = new MJRefreshNormalHeader();
            table.SetMj_header(header);

            MJRefreshAutoNormalFooter footer = new MJRefreshAutoNormalFooter();
            table.SetMj_footer(footer);

            header.RefreshingBlock = async () => {
                await Task.Delay(2000);
                InvokeOnMainThread(() => {
                    footer.Hidden = true;
                    this.Count += 12;
                    table.ReloadData();
                    table.Mj_header().EndRefreshing();
                    footer.Hidden = false;

                });
            };

            header.AutomaticallyChangeAlpha = true;

            footer.RefreshingBlock = async () => {
                await Task.Delay(2000);
                InvokeOnMainThread(() => {
                    footer.Hidden = true;
                    this.Count += 5;
                    table.ReloadData();
                    table.Mj_footer().EndRefreshing();
                    footer.Hidden = false;
                });
            };

            table.Mj_header().BeginRefreshing();
        }

    }

    public class TableDelegate : UITableViewDelegate
    {
        [Weak] ViewController _vc;
        public TableDelegate(ViewController vc)
        {
            _vc = vc;
        }
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            _vc.NavigationController.PushViewController(new MJTableViewController(), true);
        }
    }

    public class TableDataSource : UITableViewDataSource
    {
        [Weak] ViewController _vc;
        public TableDataSource(ViewController vc)
        {
            _vc = vc;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("testcell");
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, "testcell");
            cell.TextLabel.Text = $"测试数据{indexPath.Row}";
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return _vc.Count;
        }

    }
}
