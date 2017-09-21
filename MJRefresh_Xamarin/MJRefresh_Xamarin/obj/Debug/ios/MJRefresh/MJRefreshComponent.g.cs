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
	[Register("MJRefreshComponent", true)]
	public unsafe partial class MJRefreshComponent : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MJRefreshComponent");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MJRefreshComponent () : base (NSObjectFlag.Empty)
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
		public MJRefreshComponent (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MJRefreshComponent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MJRefreshComponent (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("beginRefreshing")]
		[CompilerGenerated]
		public virtual void BeginRefreshing ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("beginRefreshing"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beginRefreshing"));
			}
		}
		
		[Export ("endRefreshing")]
		[CompilerGenerated]
		public virtual void EndRefreshing ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endRefreshing"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endRefreshing"));
			}
		}
		
		[Export ("executeRefreshingCallback")]
		[CompilerGenerated]
		public virtual void ExecuteRefreshingCallback ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("executeRefreshingCallback"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("executeRefreshingCallback"));
			}
		}
		
		[Export ("placeSubviews")]
		[CompilerGenerated]
		public virtual void PlaceSubviews ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("placeSubviews"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("placeSubviews"));
			}
		}
		
		[Export ("prepare")]
		[CompilerGenerated]
		public virtual void Prepare ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepare"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prepare"));
			}
		}
		
		[Export ("scrollViewContentInsetDidChange:")]
		[CompilerGenerated]
		public virtual void ScrollViewContentInsetDidChange (NSDictionary change)
		{
			if (change == null)
				throw new ArgumentNullException ("change");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("scrollViewContentInsetDidChange:"), change.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("scrollViewContentInsetDidChange:"), change.Handle);
			}
		}
		
		[Export ("scrollViewContentOffsetDidChange:")]
		[CompilerGenerated]
		public virtual void ScrollViewContentOffsetDidChange (NSDictionary change)
		{
			if (change == null)
				throw new ArgumentNullException ("change");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("scrollViewContentOffsetDidChange:"), change.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("scrollViewContentOffsetDidChange:"), change.Handle);
			}
		}
		
		[Export ("scrollViewContentSizeDidChange:")]
		[CompilerGenerated]
		public virtual void ScrollViewContentSizeDidChange (NSDictionary change)
		{
			if (change == null)
				throw new ArgumentNullException ("change");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("scrollViewContentSizeDidChange:"), change.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("scrollViewContentSizeDidChange:"), change.Handle);
			}
		}
		
		[Export ("scrollViewPanStateDidChange:")]
		[CompilerGenerated]
		public virtual void ScrollViewPanStateDidChange (NSDictionary change)
		{
			if (change == null)
				throw new ArgumentNullException ("change");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("scrollViewPanStateDidChange:"), change.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("scrollViewPanStateDidChange:"), change.Handle);
			}
		}
		
		[Export ("setRefreshingTarget:refreshingAction:")]
		[CompilerGenerated]
		public virtual void SetRefreshingTarget (NSObject target, Selector action)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setRefreshingTarget:refreshingAction:"), target.Handle, action.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setRefreshingTarget:refreshingAction:"), target.Handle, action.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool AutoChangeAlpha {
			[Export ("isAutoChangeAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAutoChangeAlpha"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAutoChangeAlpha"));
				}
			}
			
			[Export ("setAutoChangeAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoChangeAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutoChangeAlpha:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsRefreshing {
			[Export ("isRefreshing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRefreshing"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRefreshing"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual nfloat PullingPercent {
			[Export ("pullingPercent", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pullingPercent"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pullingPercent"));
				}
			}
			
			[Export ("setPullingPercent:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPullingPercent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPullingPercent:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual Selector RefreshingAction {
			[Export ("refreshingAction", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return Selector.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("refreshingAction")));
				} else {
					return Selector.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refreshingAction")));
				}
			}
			
			[Export ("setRefreshingAction:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRefreshingAction:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRefreshingAction:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual MJRefreshComponentRefreshingBlock RefreshingBlock {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDMJRefreshComponentRefreshingBlock))]
			[Export ("refreshingBlock", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("refreshingBlock"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refreshingBlock"));
				}
				return global::ObjCRuntime.Trampolines.NIDMJRefreshComponentRefreshingBlock.Create (ret);
			}
			
			[Export ("setRefreshingBlock:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDMJRefreshComponentRefreshingBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRefreshingBlock:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRefreshingBlock:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_RefreshingTarget_var;
		[CompilerGenerated]
		public virtual NSObject RefreshingTarget {
			[Export ("refreshingTarget", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("refreshingTarget")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refreshingTarget")));
				}
				MarkDirty ();
				__mt_RefreshingTarget_var = ret;
				return ret;
			}
			
			[Export ("setRefreshingTarget:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRefreshingTarget:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRefreshingTarget:"), value.Handle);
				}
				MarkDirty ();
				__mt_RefreshingTarget_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIScrollView ScrollView {
			[Export ("scrollView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollView")));
				}
				MarkDirty ();
				__mt_ScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets ScrollViewOriginalInset {
			[Export ("scrollViewOriginalInset", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("scrollViewOriginalInset"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("scrollViewOriginalInset"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("scrollViewOriginalInset"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("scrollViewOriginalInset"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollViewOriginalInset"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("scrollViewOriginalInset"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("scrollViewOriginalInset"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("scrollViewOriginalInset"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::MJRefreshState State {
			[Export ("state", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (global::MJRefreshState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				} else {
					return (global::MJRefreshState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
				}
			}
			
			[Export ("setState:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setState:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setState:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_RefreshingTarget_var = null;
				__mt_ScrollView_var = null;
			}
		}
		public partial class MJRefreshComponentAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal MJRefreshComponentAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MJRefreshComponentAppearance Appearance {
			get { return new MJRefreshComponentAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MJRefreshComponentAppearance GetAppearance<T> () where T: MJRefreshComponent {
			return new MJRefreshComponentAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MJRefreshComponentAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MJRefreshComponentAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MJRefreshComponentAppearance GetAppearance (UITraitCollection traits) {
			return new MJRefreshComponentAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MJRefreshComponentAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MJRefreshComponentAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MJRefreshComponentAppearance GetAppearance<T> (UITraitCollection traits) where T: MJRefreshComponent {
			return new MJRefreshComponentAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MJRefreshComponentAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MJRefreshComponent{
			return new MJRefreshComponentAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MJRefreshComponent */
}
