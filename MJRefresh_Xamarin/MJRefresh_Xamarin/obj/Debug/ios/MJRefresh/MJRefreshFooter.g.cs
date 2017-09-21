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
	[Register("MJRefreshFooter", true)]
	public unsafe partial class MJRefreshFooter : MJRefreshComponent {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshFooter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshFooter () : base (NSObjectFlag.Empty)
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
		public MJRefreshFooter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshFooter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshFooter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("footerWithRefreshingBlock:")]
		[CompilerGenerated]
		public unsafe static MJRefreshFooter FooterWithRefreshingBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMJRefreshComponentRefreshingBlock))]MJRefreshComponentRefreshingBlock refreshingBlock)
		{
			if (refreshingBlock == null)
				throw new ArgumentNullException ("refreshingBlock");
			BlockLiteral *block_ptr_refreshingBlock;
			BlockLiteral block_refreshingBlock;
			block_refreshingBlock = new BlockLiteral ();
			block_ptr_refreshingBlock = &block_refreshingBlock;
			block_refreshingBlock.SetupBlock (Trampolines.SDMJRefreshComponentRefreshingBlock.Handler, refreshingBlock);
			
			MJRefreshFooter ret;
			ret =  Runtime.GetNSObject<MJRefreshFooter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("footerWithRefreshingBlock:"), (IntPtr) block_ptr_refreshingBlock));
			block_ptr_refreshingBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("footerWithRefreshingTarget:refreshingAction:")]
		[CompilerGenerated]
		public static MJRefreshFooter FooterWithRefreshingTarget (NSObject target, Selector action)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (action == null)
				throw new ArgumentNullException ("action");
			return  Runtime.GetNSObject<MJRefreshFooter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("footerWithRefreshingTarget:refreshingAction:"), target.Handle, action.Handle));
		}
		
		[Export ("noticeNoMoreData")]
		[CompilerGenerated]
		public virtual void NoticeNoMoreData ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("noticeNoMoreData"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("noticeNoMoreData"));
			}
		}
		
		[Export ("resetNoMoreData")]
		[CompilerGenerated]
		public virtual void ResetNoMoreData ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetNoMoreData"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetNoMoreData"));
			}
		}
		
		public partial class MJRefreshFooterAppearance : global::MJRefresh.MJRefreshComponent.MJRefreshComponentAppearance {
			protected internal MJRefreshFooterAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MJRefreshFooterAppearance Appearance {
			get { return new MJRefreshFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MJRefreshFooterAppearance GetAppearance<T> () where T: MJRefreshFooter {
			return new MJRefreshFooterAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MJRefreshFooterAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MJRefreshFooterAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MJRefreshFooterAppearance GetAppearance (UITraitCollection traits) {
			return new MJRefreshFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MJRefreshFooterAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MJRefreshFooterAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MJRefreshFooterAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshFooter {
			return new MJRefreshFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MJRefreshFooterAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshFooter{
			return new MJRefreshFooterAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MJRefreshFooter */
}
