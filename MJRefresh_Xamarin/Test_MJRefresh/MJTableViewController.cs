using System;
using System.Threading.Tasks;
using Foundation;
using MJRefresh;
using UIKit;
using Test_MJRefresh.DIY;

namespace Test_MJRefresh
{
    public class MJTableViewController : UITableViewController
    {
        public int Count { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TableView.Frame = new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);
            TableView.TableFooterView = new UIView();
            MJChiBaoZiHeader header = new MJChiBaoZiHeader();
            TableView.SetMj_header(header);

            MJRefreshAutoNormalFooter footer = new MJRefreshAutoNormalFooter();
            TableView.SetMj_footer(footer);

            header.RefreshingBlock = async () => {
                await Task.Delay(2000);
                InvokeOnMainThread(() => {
                    footer.Hidden = true;
                    Count += 12;
                    TableView.ReloadData();
                    TableView.Mj_header().EndRefreshing();
                    footer.Hidden = false;

                });
            };

            header.AutomaticallyChangeAlpha = true;

            footer.RefreshingBlock = async () => {
                await Task.Delay(2000);
                InvokeOnMainThread(() => {
                    footer.Hidden = true;
                    this.Count += 5;
                    this.TableView.ReloadData();
                    this.TableView.Mj_footer().EndRefreshing();
                    footer.Hidden = false;
                });
            };

            this.TableView.Mj_header().BeginRefreshing();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("testcell");
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, "testcell");
            if (indexPath.Row % 2 != 0)
                cell.TextLabel.Text = "push";
            else
                cell.TextLabel.Text = "modal";
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return this.Count;
        }
    }
}
