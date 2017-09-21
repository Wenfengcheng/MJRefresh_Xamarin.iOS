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

[Register("MJRefreshAutoNormalFooter", true)]
public unsafe partial class MJRefreshAutoNormalFooter : global::MJRefreshAutoStateFooter {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshAutoNormalFooter");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshAutoNormalFooter () : base (NSObjectFlag.Empty)
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
		public MJRefreshAutoNormalFooter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshAutoNormalFooter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshAutoNormalFooter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[CompilerGenerated]
	public virtual global::UIKit.UIActivityIndicatorViewStyle ActivityIndicatorViewStyle {
		[Export ("activityIndicatorViewStyle", ArgumentSemantic.UnsafeUnretained)]
		get {
			global::UIKit.UIActivityIndicatorViewStyle ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("activityIndicatorViewStyle"));
				} else {
					ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("activityIndicatorViewStyle"));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("activityIndicatorViewStyle"));
				} else {
					ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("activityIndicatorViewStyle"));
				}
			}
			return ret;
		}
		
		[Export ("setActivityIndicatorViewStyle:", ArgumentSemantic.UnsafeUnretained)]
		set {
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setActivityIndicatorViewStyle:"), (Int64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setActivityIndicatorViewStyle:"), (int)value);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setActivityIndicatorViewStyle:"), (Int64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setActivityIndicatorViewStyle:"), (int)value);
				}
			}
		}
	}
	
	public partial class MJRefreshAutoNormalFooterAppearance : global::MJRefreshAutoStateFooter.MJRefreshAutoStateFooterAppearance {
		protected internal MJRefreshAutoNormalFooterAppearance (IntPtr handle) : base (handle) {}
	}
	
	public static new MJRefreshAutoNormalFooterAppearance Appearance {
		get { return new MJRefreshAutoNormalFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
	}
	
	public static new MJRefreshAutoNormalFooterAppearance GetAppearance<T> () where T: MJRefreshAutoNormalFooter {
		return new MJRefreshAutoNormalFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
	}
	
	public static new MJRefreshAutoNormalFooterAppearance AppearanceWhenContainedIn (params Type [] containers)
	{
		return new MJRefreshAutoNormalFooterAppearance (UIAppearance.GetAppearance (class_ptr, containers));
	}
	
	public static new MJRefreshAutoNormalFooterAppearance GetAppearance (UITraitCollection traits) {
		return new MJRefreshAutoNormalFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits));
	}
	
	public static new MJRefreshAutoNormalFooterAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
		return new MJRefreshAutoNormalFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
	}
	
	public static new MJRefreshAutoNormalFooterAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshAutoNormalFooter {
		return new MJRefreshAutoNormalFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
	}
	
	public static new MJRefreshAutoNormalFooterAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshAutoNormalFooter{
		return new MJRefreshAutoNormalFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
	}
	
	
} /* class MJRefreshAutoNormalFooter */
