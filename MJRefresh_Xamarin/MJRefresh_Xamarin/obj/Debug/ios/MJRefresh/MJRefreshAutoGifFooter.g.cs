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
	[Register("MJRefreshAutoGifFooter", true)]
	public unsafe partial class MJRefreshAutoGifFooter : MJRefreshAutoStateFooter {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshAutoGifFooter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshAutoGifFooter () : base (NSObjectFlag.Empty)
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
		public MJRefreshAutoGifFooter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshAutoGifFooter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshAutoGifFooter (IntPtr handle) : base (handle)
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
		
		public partial class MJRefreshAutoGifFooterAppearance : global::MJRefresh.MJRefreshAutoStateFooter.MJRefreshAutoStateFooterAppearance {
			protected internal MJRefreshAutoGifFooterAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MJRefreshAutoGifFooterAppearance Appearance {
			get { return new MJRefreshAutoGifFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MJRefreshAutoGifFooterAppearance GetAppearance<T> () where T: MJRefreshAutoGifFooter {
			return new MJRefreshAutoGifFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MJRefreshAutoGifFooterAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MJRefreshAutoGifFooterAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MJRefreshAutoGifFooterAppearance GetAppearance (UITraitCollection traits) {
			return new MJRefreshAutoGifFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MJRefreshAutoGifFooterAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MJRefreshAutoGifFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MJRefreshAutoGifFooterAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshAutoGifFooter {
			return new MJRefreshAutoGifFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MJRefreshAutoGifFooterAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshAutoGifFooter{
			return new MJRefreshAutoGifFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MJRefreshAutoGifFooter */
}
