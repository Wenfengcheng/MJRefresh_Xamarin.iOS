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
	[Register("MJRefreshBackGifFooter", true)]
	public unsafe partial class MJRefreshBackGifFooter : MJRefreshBackStateFooter {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshBackGifFooter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshBackGifFooter () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MJRefreshBackGifFooter (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MJRefreshBackGifFooter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshBackGifFooter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setImages:duration:forState:")]
		[CompilerGenerated]
		public virtual void SetImages (global::UIKit.UIImage[] images, double duration, global::MJRefreshState state)
		{
			if (images == null)
				throw new ArgumentNullException ("images");
			var nsa_images = NSArray.FromNSObjects (images);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_int (this.Handle, Selector.GetHandle ("setImages:duration:forState:"), nsa_images.Handle, duration, (int)state);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_Double_int (this.SuperHandle, Selector.GetHandle ("setImages:duration:forState:"), nsa_images.Handle, duration, (int)state);
			}
			nsa_images.Dispose ();
			
		}
		
		[Export ("setImages:forState:")]
		[CompilerGenerated]
		public virtual void SetImages (global::UIKit.UIImage[] images, global::MJRefreshState state)
		{
			if (images == null)
				throw new ArgumentNullException ("images");
			var nsa_images = NSArray.FromNSObjects (images);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("setImages:forState:"), nsa_images.Handle, (int)state);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("setImages:forState:"), nsa_images.Handle, (int)state);
			}
			nsa_images.Dispose ();
			
		}
		
		public partial class MJRefreshBackGifFooterAppearance : global::MJRefresh.MJRefreshBackStateFooter.MJRefreshBackStateFooterAppearance {
			protected internal MJRefreshBackGifFooterAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MJRefreshBackGifFooterAppearance Appearance {
			get { return new MJRefreshBackGifFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MJRefreshBackGifFooterAppearance GetAppearance<T> () where T: MJRefreshBackGifFooter {
			return new MJRefreshBackGifFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MJRefreshBackGifFooterAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MJRefreshBackGifFooterAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MJRefreshBackGifFooterAppearance GetAppearance (UITraitCollection traits) {
			return new MJRefreshBackGifFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MJRefreshBackGifFooterAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MJRefreshBackGifFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MJRefreshBackGifFooterAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshBackGifFooter {
			return new MJRefreshBackGifFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MJRefreshBackGifFooterAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshBackGifFooter{
			return new MJRefreshBackGifFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MJRefreshBackGifFooter */
}
