using System;
using MJRefresh;
using UIKit;

using Foundation;
using System.Collections.Generic;

namespace Test_MJRefresh.DIY
{
    public class MJChiBaoZiHeader : MJRefreshGifHeader
    {
        public override void Prepare()
        {
            base.Prepare();

            NSMutableArray refreshImages = new NSMutableArray();

            for (int i = 1; i < 3;i++)
            {
                UIImage image = new UIImage($"dropdown_loading_0{i}");
                refreshImages.Add(image);
            }

            this.SetImages(refreshImages, MJRefreshState.Pulling);

            this.SetImages(refreshImages , MJRefreshState.Refreshing);
        }
    }
}
