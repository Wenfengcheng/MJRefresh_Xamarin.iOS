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

[Register("MJRefreshBackFooter", true)]
public unsafe partial class MJRefreshBackFooter : global::MJRefreshFooter {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshBackFooter");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshBackFooter () : base (NSObjectFlag.Empty)
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
		public MJRefreshBackFooter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshBackFooter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshBackFooter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	public partial class MJRefreshBackFooterAppearance : global::MJRefreshFooter.MJRefreshFooterAppearance {
		protected internal MJRefreshBackFooterAppearance (IntPtr handle) : base (handle) {}
	}
	
	public static new MJRefreshBackFooterAppearance Appearance {
		get { return new MJRefreshBackFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
	}
	
	public static new MJRefreshBackFooterAppearance GetAppearance<T> () where T: MJRefreshBackFooter {
		return new MJRefreshBackFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
	}
	
	public static new MJRefreshBackFooterAppearance AppearanceWhenContainedIn (params Type [] containers)
	{
		return new MJRefreshBackFooterAppearance (UIAppearance.GetAppearance (class_ptr, containers));
	}
	
	public static new MJRefreshBackFooterAppearance GetAppearance (UITraitCollection traits) {
		return new MJRefreshBackFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits));
	}
	
	public static new MJRefreshBackFooterAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
		return new MJRefreshBackFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
	}
	
	public static new MJRefreshBackFooterAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshBackFooter {
		return new MJRefreshBackFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
	}
	
	public static new MJRefreshBackFooterAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshBackFooter{
		return new MJRefreshBackFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
	}
	
	
} /* class MJRefreshBackFooter */
