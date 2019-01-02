using System;
using System.Collections.Generic;
using MJRefresh;
using UIKit;
using Test_MJRefresh.Helper;

namespace Test_MJRefresh.DIY
{
    public class BossRefreshHeader : MJRefreshGifHeader
    {
        public override void Prepare()
        {
            base.Prepare();

            this.LabelLeftInset = 20;

            List<UIImage> idleImages = new List<UIImage>();
            for (int i = 1; i <= 60; i++)
            {
                UIImage image = UIImage.FromFile($"{i}p");
                idleImages.Add(image);
            }

            this.SetImages(idleImages.ToArray(), MJRefreshState.Idle);

            List<UIImage> refreshingImages = new List<UIImage>();
            for (int i = 1; i <= 24; i++)
            {
                UIImage image = UIImage.FromFile($"{i}r");
                refreshingImages.Add(image);
            }
            this.SetImages(refreshingImages.ToArray(), MJRefreshState.Pulling);
            this.SetImages(refreshingImages.ToArray(), MJRefreshState.Refreshing);

            this.LastUpdatedTimeLabel.Hidden = true;
            this.StateLabel.Hidden = true;
        }

        public override void PlaceSubviews()
        {
            base.PlaceSubviews();

            this.GifView.SetMJ_Height(120 * 0.5f);
            this.GifView.SetMJ_Width(120 * 0.5f);
            this.GifView.SetMJ_X((this.MJ_Width() - this.GifView.MJ_Width())/2.0f);
            this.GifView.SetMJ_Y((this.MJ_Height() - this.GifView.MJ_Height()) / 2.0f + 5);

            this.GifView.ContentMode = UIViewContentMode.ScaleAspectFill;
        }

        public override void SetImages(UIImage[] images, MJRefreshState state)
        {
            this.SetImages(images, images.Length *0.1, state);
        }

        public override void SetImages(UIImage[] images, double duration, MJRefreshState state)
        {
            base.SetImages(images, duration, state);

            this.SetMJ_Height(75);
        }
    }
}
