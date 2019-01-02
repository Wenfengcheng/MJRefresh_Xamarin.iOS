using System;
using CoreGraphics;
using UIKit;

namespace Test_MJRefresh.Helper
{
    public static class UIView_MJExtension
    {
        /// <summary>
        /// Get the x.
        /// </summary>
        public static nfloat MJ_X(this UIView v)
        {
            return v.Frame.X;
        }

        /// <summary>
        /// Sets the x.
        /// </summary>
        public static void SetMJ_X(this UIView v, nfloat x)
        {
            v.Frame = new CGRect(x, v.Frame.Y, v.Frame.Width, v.Frame.Height);
        }

        /// <summary>
        /// Get the y.
        /// </summary>
        public static nfloat MJ_Y(this UIView v)
        {
            return v.Frame.Y;
        }

        /// <summary>
        /// Sets the y.
        /// </summary>
        public static void SetMJ_Y(this UIView v, nfloat y)
        {
            v.Frame = new CGRect(v.Frame.X, y, v.Frame.Width, v.Frame.Height);
        }

        /// <summary>
        /// Get the height.
        /// </summary>
        public static nfloat MJ_Height(this UIView v)
        {
            return v.Frame.Height;
        }

        /// <summary>
        /// Sets the height.
        /// </summary>
        public static void SetMJ_Height(this UIView v, nfloat h)
        {
            v.SetMJ_Frame(v.Frame.X, v.Frame.Y, v.Frame.Width, h);
        }

        /// <summary>
        /// Get the width.
        /// </summary>
        public static nfloat MJ_Width(this UIView v)
        {
            return v.Frame.Width;
        }

        /// <summary>
        /// Sets the width.
        /// </summary>
        public static void SetMJ_Width(this UIView v, nfloat w)
        {
            v.SetMJ_Frame(v.Frame.X, v.Frame.Y, w, v.Frame.Height);
        }

        /// <summary>
        /// Get the left.
        /// </summary>
        public static nfloat MJ_Left(this UIView v)
        {
            return v.Frame.X;
        }

        /// <summary>
        /// Sets the left.
        /// </summary>
        public static void SetMJ_Left(this UIView v, nfloat left)
        {
            v.SetMJ_Frame(left, v.Frame.Y, v.Frame.Width, v.Frame.Height);
        }

        /// <summary>
        /// Get the right.
        /// </summary>
        public static nfloat MJ_Right(this UIView v)
        {
            return v.Frame.X + v.Frame.Width;
        }

        /// <summary>
        /// Sets the right.
        /// </summary>
        public static void SetMJ_Right(this UIView v, nfloat right)
        {
            v.SetMJ_Frame(right - v.Frame.Width, v.Frame.Y, v.Frame.Width, v.Frame.Height);
        }

        /// <summary>
        /// Get the center x.
        /// </summary>
        public static nfloat MJ_CenterX(this UIView v)
        {
            return v.Center.X;
        }

        /// <summary>
        /// Sets the center x.
        /// </summary>
        public static void SetMJ_CenterX(this UIView v, nfloat centerX)
        {
            v.Center = new CGPoint(centerX, v.Center.Y);
        }

        /// <summary>
        /// Sets the center y.
        /// </summary>
        public static nfloat MJ_CenterY(this UIView v)
        {
            return v.Center.Y;
        }

        /// <summary>
        /// Sets the center y.
        /// </summary>
        public static void SetMJ_CenterY(this UIView v, nfloat centerY)
        {
            v.Center = new CGPoint(v.Center.X, centerY);
        }

        /// <summary>
        /// Get the top.
        /// </summary>
        public static nfloat MJ_Top(this UIView v)
        {
            return v.Frame.Y;
        }

        /// <summary>
        /// Sets the top.
        /// </summary>
        public static void SetMJ_Top(this UIView v, nfloat top)
        {
            v.SetMJ_Y(top);
        }

        /// <summary>
        /// Get the bottom.
        /// </summary>
        public static nfloat MJ_Bottom(this UIView v)
        {
            return v.Frame.Y + v.Frame.Height;
        }

        /// <summary>
        /// Sets the bottom.
        /// </summary>
        public static void SetMJ_Bottom(this UIView v, nfloat bottom)
        {
            v.SetMJ_Top(bottom - v.Frame.Height);
        }

        /// <summary>
        /// Get the location.
        /// </summary>
        public static CGPoint MJ_Location(this UIView v)
        {
            return v.Frame.Location;
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="location">Location.</param>
        public static void SetMJ_Location(this UIView v, CGPoint location)
        {
            v.Frame = new CGRect(location, v.Frame.Size);
        }

        /// <summary>
        /// Sets the location with x and y.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        public static void SetMJ_Location(this UIView v, nfloat x, nfloat y)
        {
            var location = new CGPoint(x, y);
            v.SetMJ_Location(location);
        }

        /// <summary>
        /// Get the size.
        /// </summary>
        /// <returns>The size.</returns>
        /// <param name="v">V.</param>
        public static CGSize MJ_Size(this UIView v)
        {
            return v.Frame.Size;
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="v">V.</param>
        /// <param name="size">Size.</param>
        public static void SetMJ_Size(this UIView v, CGSize size)
        {
            v.Frame = new CGRect(v.Frame.Location, size);
        }

        /// <summary>
        /// Sets the size with width and height.
        /// </summary>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        public static void SetMJ_Size(this UIView v, nfloat width, nfloat height)
        {
            var size = new CGSize(width, height);
            v.SetMJ_Size(size);
        }

        /// <summary>
        /// Sets the frame with rect.
        /// </summary>
        /// <param name="rect">Rect.</param>
        public static void SetMJ_Frame(this UIView v, CGRect rect)
        {
            v.Frame = rect;
        }

        /// <summary>
        /// Sets the frame with point and size.
        /// </summary>
        /// <param name="point">Point.</param>
        /// <param name="size">Size.</param>
        public static void SetMJ_Frame(this UIView v, CGPoint point, CGSize size)
        {
            var rect = new CGRect(point, size);
            v.Frame = rect;
        }

        /// <summary>
        /// Sets the frame with x, y, width and height.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        public static void SetMJ_Frame(this UIView v, nfloat x, nfloat y, nfloat width, nfloat height)
        {
            var rect = new CGRect(x, y, width, height);
            v.Frame = rect;
        }

    }
}
