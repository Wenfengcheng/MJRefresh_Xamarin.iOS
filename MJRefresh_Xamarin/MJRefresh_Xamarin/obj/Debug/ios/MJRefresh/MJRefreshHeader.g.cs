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
	[Register("MJRefreshHeader", true)]
	public unsafe partial class MJRefreshHeader : MJRefreshComponent {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshHeader");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshHeader () : base (NSObjectFlag.Empty)
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
		public MJRefreshHeader (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshHeader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshHeader (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("headerWithRefreshingBlock:")]
		[CompilerGenerated]
		public unsafe static MJRefreshHeader HeaderWithRefreshingBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMJRefreshComponentRefreshingBlock))]MJRefreshComponentRefreshingBlock refreshingBlock)
		{
			if (refreshingBlock == null)
				throw new ArgumentNullException ("refreshingBlock");
			BlockLiteral *block_ptr_refreshingBlock;
			BlockLiteral block_refreshingBlock;
			block_refreshingBlock = new BlockLiteral ();
			block_ptr_refreshingBlock = &block_refreshingBlock;
			block_refreshingBlock.SetupBlock (Trampolines.SDMJRefreshComponentRefreshingBlock.Handler, refreshingBlock);
			
			MJRefreshHeader ret;
			ret =  Runtime.GetNSObject<MJRefreshHeader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("headerWithRefreshingBlock:"), (IntPtr) block_ptr_refreshingBlock));
			block_ptr_refreshingBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("headerWithRefreshingTarget:refreshingAction:")]
		[CompilerGenerated]
		public static MJRefreshHeader HeaderWithRefreshingTarget (NSObject target, Selector action)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (action == null)
				throw new ArgumentNullException ("action");
			return  Runtime.GetNSObject<MJRefreshHeader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("headerWithRefreshingTarget:refreshingAction:"), target.Handle, action.Handle));
		}
		
		[CompilerGenerated]
		public virtual NSDate LastUpdatedTime {
			[Export ("lastUpdatedTime", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastUpdatedTime")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastUpdatedTime")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string LastUpdatedTimeKey {
			[Export ("lastUpdatedTimeKey")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastUpdatedTimeKey")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastUpdatedTimeKey")));
				}
			}
			
			[Export ("setLastUpdatedTimeKey:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLastUpdatedTimeKey:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLastUpdatedTimeKey:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		public partial class MJRefreshHeaderAppearance : global::MJRefresh.MJRefreshComponent.MJRefreshComponentAppearance {
			protected internal MJRefreshHeaderAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MJRefreshHeaderAppearance Appearance {
			get { return new MJRefreshHeaderAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MJRefreshHeaderAppearance GetAppearance<T> () where T: MJRefreshHeader {
			return new MJRefreshHeaderAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MJRefreshHeaderAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MJRefreshHeaderAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MJRefreshHeaderAppearance GetAppearance (UITraitCollection traits) {
			return new MJRefreshHeaderAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MJRefreshHeaderAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MJRefreshHeaderAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MJRefreshHeaderAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshHeader {
			return new MJRefreshHeaderAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MJRefreshHeaderAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshHeader{
			return new MJRefreshHeaderAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MJRefreshHeader */
}
