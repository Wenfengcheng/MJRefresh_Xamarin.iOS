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

[Register("MJRefreshNormalHeader", true)]
public unsafe partial class MJRefreshNormalHeader : global::MJRefreshStateHeader {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshNormalHeader");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshNormalHeader () : base (NSObjectFlag.Empty)
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
		public MJRefreshNormalHeader (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshNormalHeader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshNormalHeader (IntPtr handle) : base (handle)
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
	
	[CompilerGenerated]
	object __mt_ArrowView_var;
	[CompilerGenerated]
	public virtual global::UIKit.UIImageView ArrowView {
		[Export ("arrowView", ArgumentSemantic.Weak)]
		get {
			global::UIKit.UIImageView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("arrowView")));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("arrowView")));
			}
			MarkDirty ();
			__mt_ArrowView_var = ret;
			return ret;
		}
		
	}
	
	[CompilerGenerated]
	protected override void Dispose (bool disposing)
	{
		base.Dispose (disposing);
		if (Handle == IntPtr.Zero) {
			__mt_ArrowView_var = null;
		}
	}
	public partial class MJRefreshNormalHeaderAppearance : global::MJRefreshStateHeader.MJRefreshStateHeaderAppearance {
		protected internal MJRefreshNormalHeaderAppearance (IntPtr handle) : base (handle) {}
	}
	
	public static new MJRefreshNormalHeaderAppearance Appearance {
		get { return new MJRefreshNormalHeaderAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
	}
	
	public static new MJRefreshNormalHeaderAppearance GetAppearance<T> () where T: MJRefreshNormalHeader {
		return new MJRefreshNormalHeaderAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
	}
	
	public static new MJRefreshNormalHeaderAppearance AppearanceWhenContainedIn (params Type [] containers)
	{
		return new MJRefreshNormalHeaderAppearance (UIAppearance.GetAppearance (class_ptr, containers));
	}
	
	public static new MJRefreshNormalHeaderAppearance GetAppearance (UITraitCollection traits) {
		return new MJRefreshNormalHeaderAppearance (UIAppearance.GetAppearance (class_ptr, traits));
	}
	
	public static new MJRefreshNormalHeaderAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
		return new MJRefreshNormalHeaderAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
	}
	
	public static new MJRefreshNormalHeaderAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshNormalHeader {
		return new MJRefreshNormalHeaderAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
	}
	
	public static new MJRefreshNormalHeaderAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshNormalHeader{
		return new MJRefreshNormalHeaderAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
	}
	
	
} /* class MJRefreshNormalHeader */
