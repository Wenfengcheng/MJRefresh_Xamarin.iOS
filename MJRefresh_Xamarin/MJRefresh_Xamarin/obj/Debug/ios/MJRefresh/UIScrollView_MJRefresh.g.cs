//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace MJRefresh {
	public unsafe static partial class UIScrollView_MJRefresh  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIScrollView");
		
		[Export ("footer")]
		[CompilerGenerated]
		public static MJRefreshFooter GetFooter (this global::UIKit.UIScrollView This)
		{
			return  Runtime.GetNSObject<MJRefreshFooter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("footer")));
		}
		
		[Export ("header")]
		[CompilerGenerated]
		public static MJRefreshHeader GetHeader (this global::UIKit.UIScrollView This)
		{
			return  Runtime.GetNSObject<MJRefreshHeader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("header")));
		}
		
		[Export ("setFooter:")]
		[CompilerGenerated]
		public static void SetFooter (this global::UIKit.UIScrollView This, MJRefreshFooter footet)
		{
			if (footet == null)
				throw new ArgumentNullException ("footet");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setFooter:"), footet.Handle);
		}
		
		[Export ("setHeader:")]
		[CompilerGenerated]
		public static void SetHeader (this global::UIKit.UIScrollView This, MJRefreshHeader header)
		{
			if (header == null)
				throw new ArgumentNullException ("header");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setHeader:"), header.Handle);
		}
		
	} /* class UIScrollView_MJRefresh */
}
