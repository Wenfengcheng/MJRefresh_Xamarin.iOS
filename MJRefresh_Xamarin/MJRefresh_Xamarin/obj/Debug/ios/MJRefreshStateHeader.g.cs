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

[Register("MJRefreshStateHeader", true)]
public unsafe partial class MJRefreshStateHeader : global::MJRefreshHeader {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshStateHeader");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshStateHeader () : base (NSObjectFlag.Empty)
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
		public MJRefreshStateHeader (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshStateHeader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshStateHeader (IntPtr handle) : base (handle)
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
	object __mt_LastUpdatedTimeLabel_var;
	[CompilerGenerated]
	public virtual global::UIKit.UILabel LastUpdatedTimeLabel {
		[Export ("lastUpdatedTimeLabel", ArgumentSemantic.Weak)]
		get {
			global::UIKit.UILabel ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastUpdatedTimeLabel")));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastUpdatedTimeLabel")));
			}
			MarkDirty ();
			__mt_LastUpdatedTimeLabel_var = ret;
			return ret;
		}
		
	}
	
	[CompilerGenerated]
	public unsafe virtual global::System.Func<NSDate, NSString> LastUpdatedTimeText {
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDFuncArity2V0))]
		[Export ("lastUpdatedTimeText", ArgumentSemantic.Copy)]
		get {
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastUpdatedTimeText"));
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastUpdatedTimeText"));
			}
			return global::ObjCRuntime.Trampolines.NIDFuncArity2V0.Create (ret);
		}
		
		[Export ("setLastUpdatedTimeText:", ArgumentSemantic.Copy)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			BlockLiteral *block_ptr_value;
			BlockLiteral block_value;
			block_value = new BlockLiteral ();
			block_ptr_value = &block_value;
			block_value.SetupBlock (Trampolines.SDFuncArity2V0.Handler, value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLastUpdatedTimeText:"), (IntPtr) block_ptr_value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLastUpdatedTimeText:"), (IntPtr) block_ptr_value);
			}
			block_ptr_value->CleanupBlock ();
			
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
			__mt_LastUpdatedTimeLabel_var = null;
			__mt_StateLabel_var = null;
		}
	}
	public partial class MJRefreshStateHeaderAppearance : global::MJRefreshHeader.MJRefreshHeaderAppearance {
		protected internal MJRefreshStateHeaderAppearance (IntPtr handle) : base (handle) {}
	}
	
	public static new MJRefreshStateHeaderAppearance Appearance {
		get { return new MJRefreshStateHeaderAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
	}
	
	public static new MJRefreshStateHeaderAppearance GetAppearance<T> () where T: MJRefreshStateHeader {
		return new MJRefreshStateHeaderAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
	}
	
	public static new MJRefreshStateHeaderAppearance AppearanceWhenContainedIn (params Type [] containers)
	{
		return new MJRefreshStateHeaderAppearance (UIAppearance.GetAppearance (class_ptr, containers));
	}
	
	public static new MJRefreshStateHeaderAppearance GetAppearance (UITraitCollection traits) {
		return new MJRefreshStateHeaderAppearance (UIAppearance.GetAppearance (class_ptr, traits));
	}
	
	public static new MJRefreshStateHeaderAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
		return new MJRefreshStateHeaderAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
	}
	
	public static new MJRefreshStateHeaderAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshStateHeader {
		return new MJRefreshStateHeaderAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
	}
	
	public static new MJRefreshStateHeaderAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshStateHeader{
		return new MJRefreshStateHeaderAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
	}
	
	
} /* class MJRefreshStateHeader */
