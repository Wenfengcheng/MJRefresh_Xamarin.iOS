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

            UIImage[] refreshImages = new UIImage[3];

            for (int i = 0; i < 3;i++)
            {
                UIImage image = new UIImage($"dropdown_loading_0{i+1}");
                refreshImages[i] = image;
            }

            this.SetImages(refreshImages, MJRefreshState.Pulling);

            this.SetImages(refreshImages , MJRefreshState.Refreshing);
        }
    }
}
