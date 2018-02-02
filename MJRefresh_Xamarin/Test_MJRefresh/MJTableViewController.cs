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

        public MJTableViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.TableView.Frame = new CoreGraphics.CGRect(0, 40, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height - 64 - 40);

            MJChiBaoZiHeader header = new MJChiBaoZiHeader();
            this.TableView.SetHeader(header);

            MJRefreshAutoNormalFooter footer = new MJRefreshAutoNormalFooter();
            this.TableView.SetFooter(footer);

            header.RefreshingBlock = async () => {
                await Task.Delay(2000);
                InvokeOnMainThread(() => {
                    footer.Hidden = true;
                    this.Count += 12;
                    this.TableView.ReloadData();
                    this.TableView.Header().EndRefreshing();
                    footer.Hidden = false;

                });
            };

            header.SetTitle(NSBundle_MJRefresh.Mj_localizedStringForKey(NSBundle_MJRefresh.Mj_refreshBundle(NSBundle.MainBundle),"MJRefreshHeaderIdleText"), MJRefreshState.Idle);
            header.SetTitle(NSBundle_MJRefresh.Mj_localizedStringForKey(NSBundle_MJRefresh.Mj_refreshBundle(NSBundle.MainBundle), "MJRefreshHeaderPullingText"), MJRefreshState.Pulling);
            header.SetTitle(NSBundle_MJRefresh.Mj_localizedStringForKey(NSBundle_MJRefresh.Mj_refreshBundle(NSBundle.MainBundle), "MJRefreshHeaderRefreshingText"), MJRefreshState.Refreshing);

            header.AutomaticallyChangeAlpha = true;


            footer.RefreshingBlock = async () => {
                await Task.Delay(2000);
                InvokeOnMainThread(() => {
                    footer.Hidden = true;
                    this.Count += 5;
                    this.TableView.ReloadData();
                    this.TableView.Footer().EndRefreshing();
                    footer.Hidden = false;
                });
            };

            footer.SetTitle(NSBundle_MJRefresh.Mj_localizedStringForKey(NSBundle_MJRefresh.Mj_refreshBundle(NSBundle.MainBundle), "MJRefreshAutoFooterIdleText"), MJRefreshState.Idle);
            footer.SetTitle(NSBundle_MJRefresh.Mj_localizedStringForKey(NSBundle_MJRefresh.Mj_refreshBundle(NSBundle.MainBundle), "MJRefreshAutoFooterRefreshingText"), MJRefreshState.Refreshing);
            footer.SetTitle(NSBundle_MJRefresh.Mj_localizedStringForKey(NSBundle_MJRefresh.Mj_refreshBundle(NSBundle.MainBundle), "MJRefreshAutoFooterNoMoreDataText"), MJRefreshState.NoMoreData);



            this.TableView.Header().BeginRefreshing();
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
