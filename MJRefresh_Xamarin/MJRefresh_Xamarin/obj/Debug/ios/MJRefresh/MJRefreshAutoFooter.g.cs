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
	[Register("MJRefreshAutoFooter", true)]
	public unsafe partial class MJRefreshAutoFooter : MJRefreshFooter {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshAutoFooter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshAutoFooter () : base (NSObjectFlag.Empty)
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
		public MJRefreshAutoFooter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshAutoFooter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshAutoFooter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual nfloat AppearencePercentTriggerAutoRefresh {
			[Export ("appearencePercentTriggerAutoRefresh", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("appearencePercentTriggerAutoRefresh"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appearencePercentTriggerAutoRefresh"));
				}
			}
			
			[Export ("setAppearencePercentTriggerAutoRefresh:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAppearencePercentTriggerAutoRefresh:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAppearencePercentTriggerAutoRefresh:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AutomaticallyRefresh {
			[Export ("isAutomaticallyRefresh")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAutomaticallyRefresh"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAutomaticallyRefresh"));
				}
			}
			
			[Export ("setAutomaticallyRefresh:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutomaticallyRefresh:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutomaticallyRefresh:"), value);
				}
			}
		}
		
		public partial class MJRefreshAutoFooterAppearance : global::MJRefresh.MJRefreshFooter.MJRefreshFooterAppearance {
			protected internal MJRefreshAutoFooterAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MJRefreshAutoFooterAppearance Appearance {
			get { return new MJRefreshAutoFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MJRefreshAutoFooterAppearance GetAppearance<T> () where T: MJRefreshAutoFooter {
			return new MJRefreshAutoFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MJRefreshAutoFooterAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MJRefreshAutoFooterAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MJRefreshAutoFooterAppearance GetAppearance (UITraitCollection traits) {
			return new MJRefreshAutoFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MJRefreshAutoFooterAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MJRefreshAutoFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MJRefreshAutoFooterAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshAutoFooter {
			return new MJRefreshAutoFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MJRefreshAutoFooterAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshAutoFooter{
			return new MJRefreshAutoFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MJRefreshAutoFooter */
}
