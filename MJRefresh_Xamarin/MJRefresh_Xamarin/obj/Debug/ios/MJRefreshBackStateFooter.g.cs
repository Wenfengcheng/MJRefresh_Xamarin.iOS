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

[Register("MJRefreshBackStateFooter", true)]
public unsafe partial class MJRefreshBackStateFooter : global::MJRefreshBackFooter {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshBackStateFooter");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshBackStateFooter () : base (NSObjectFlag.Empty)
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
		public MJRefreshBackStateFooter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshBackStateFooter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshBackStateFooter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("setTitle:forState:")]
	[CompilerGenerated]
	public virtual void SetTitle (string title, global::MJRefreshState state)
	{
		if (title == null)
			throw new ArgumentNullException ("title");
		var nstitle = NSString.CreateNative (title);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("setTitle:forState:"), nstitle, (int)state);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("setTitle:forState:"), nstitle, (int)state);
		}
		NSString.ReleaseNative (nstitle);
		
	}
	
	[Export ("titleForState:")]
	[CompilerGenerated]
	public virtual string TitleForState (global::MJRefreshState state)
	{
		if (IsDirectBinding) {
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("titleForState:"), (int)state));
		} else {
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("titleForState:"), (int)state));
		}
	}
	
	[CompilerGenerated]
	public virtual nfloat LabelLeftInset {
		[Export ("labelLeftInset")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("labelLeftInset"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labelLeftInset"));
			}
		}
		
		[Export ("setLabelLeftInset:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLabelLeftInset:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLabelLeftInset:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	object __mt_StateLabel_var;
	[CompilerGenerated]
	public virtual global::UIKit.UILabel StateLabel {
		[Export ("stateLabel", ArgumentSemantic.Weak)]
		get {
			global::UIKit.UILabel ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stateLabel")));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stateLabel")));
			}
			MarkDirty ();
			__mt_StateLabel_var = ret;
			return ret;
		}
		
	}
	
	[CompilerGenerated]
	protected override void Dispose (bool disposing)
	{
		base.Dispose (disposing);
		if (Handle == IntPtr.Zero) {
			__mt_StateLabel_var = null;
		}
	}
	public partial class MJRefreshBackStateFooterAppearance : global::MJRefreshBackFooter.MJRefreshBackFooterAppearance {
		protected internal MJRefreshBackStateFooterAppearance (IntPtr handle) : base (handle) {}
	}
	
	public static new MJRefreshBackStateFooterAppearance Appearance {
		get { return new MJRefreshBackStateFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
	}
	
	public static new MJRefreshBackStateFooterAppearance GetAppearance<T> () where T: MJRefreshBackStateFooter {
		return new MJRefreshBackStateFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
	}
	
	public static new MJRefreshBackStateFooterAppearance AppearanceWhenContainedIn (params Type [] containers)
	{
		return new MJRefreshBackStateFooterAppearance (UIAppearance.GetAppearance (class_ptr, containers));
	}
	
	public static new MJRefreshBackStateFooterAppearance GetAppearance (UITraitCollection traits) {
		return new MJRefreshBackStateFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits));
	}
	
	public static new MJRefreshBackStateFooterAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
		return new MJRefreshBackStateFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
	}
	
	public static new MJRefreshBackStateFooterAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshBackStateFooter {
		return new MJRefreshBackStateFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
	}
	
	public static new MJRefreshBackStateFooterAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshBackStateFooter{
		return new MJRefreshBackStateFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
	}
	
	
} /* class MJRefreshBackStateFooter */
