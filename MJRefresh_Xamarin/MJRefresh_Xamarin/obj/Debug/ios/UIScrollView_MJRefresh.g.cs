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

public unsafe static partial class UIScrollView_MJRefresh  {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("UIScrollView");
	
	[CompilerGenerated]
	[Introduced (PlatformName.iOS, 2,0, message: "使用mj_footer")]
	[Deprecated (PlatformName.iOS, 2,0, message: "使用mj_footer")]
	public virtual global::MJRefreshFooter Footer {
		[Introduced (PlatformName.iOS, 2,0, message: "使用mj_footer")]
		[Deprecated (PlatformName.iOS, 2,0, message: "使用mj_footer")]
		[Export ("footer", ArgumentSemantic.Retain)]
		get {
			global::MJRefreshFooter ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::MJRefreshFooter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("footer")));
			} else {
				ret =  Runtime.GetNSObject<global::MJRefreshFooter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("footer")));
			}
			return ret;
		}
		
		[Introduced (PlatformName.iOS, 2,0, message: "使用mj_footer")]
		[Deprecated (PlatformName.iOS, 2,0, message: "使用mj_footer")]
		[Export ("setFooter:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFooter:"), value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFooter:"), value.Handle);
			}
		}
	}
	
	[CompilerGenerated]
	[Introduced (PlatformName.iOS, 2,0, message: "使用mj_header")]
	[Deprecated (PlatformName.iOS, 2,0, message: "使用mj_header")]
	public virtual global::MJRefreshHeader Header {
		[Introduced (PlatformName.iOS, 2,0, message: "使用mj_header")]
		[Deprecated (PlatformName.iOS, 2,0, message: "使用mj_header")]
		[Export ("header", ArgumentSemantic.Retain)]
		get {
			global::MJRefreshHeader ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::MJRefreshHeader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("header")));
			} else {
				ret =  Runtime.GetNSObject<global::MJRefreshHeader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("header")));
			}
			return ret;
		}
		
		[Introduced (PlatformName.iOS, 2,0, message: "使用mj_header")]
		[Deprecated (PlatformName.iOS, 2,0, message: "使用mj_header")]
		[Export ("setHeader:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeader:"), value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeader:"), value.Handle);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual global::MJRefreshFooter Mj_footer {
		[Export ("mj_footer", ArgumentSemantic.Retain)]
		get {
			global::MJRefreshFooter ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::MJRefreshFooter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mj_footer")));
			} else {
				ret =  Runtime.GetNSObject<global::MJRefreshFooter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_footer")));
			}
			return ret;
		}
		
		[Export ("setMj_footer:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMj_footer:"), value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMj_footer:"), value.Handle);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual global::MJRefreshHeader Mj_header {
		[Export ("mj_header", ArgumentSemantic.Retain)]
		get {
			global::MJRefreshHeader ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::MJRefreshHeader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mj_header")));
			} else {
				ret =  Runtime.GetNSObject<global::MJRefreshHeader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_header")));
			}
			return ret;
		}
		
		[Export ("setMj_header:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMj_header:"), value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMj_header:"), value.Handle);
			}
		}
	}
	
	[CompilerGenerated]
	public unsafe virtual global::System.Action<nint> Mj_reloadDataBlock {
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V0))]
		[Export ("mj_reloadDataBlock", ArgumentSemantic.Copy)]
		get {
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mj_reloadDataBlock"));
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_reloadDataBlock"));
			}
			return global::ObjCRuntime.Trampolines.NIDActionArity1V0.Create (ret);
		}
		
		[Export ("setMj_reloadDataBlock:", ArgumentSemantic.Copy)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			BlockLiteral *block_ptr_value;
			BlockLiteral block_value;
			block_value = new BlockLiteral ();
			block_ptr_value = &block_value;
			block_value.SetupBlock (Trampolines.SDActionArity1V0.Handler, value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMj_reloadDataBlock:"), (IntPtr) block_ptr_value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMj_reloadDataBlock:"), (IntPtr) block_ptr_value);
			}
			block_ptr_value->CleanupBlock ();
			
		}
	}
	
	[CompilerGenerated]
	public virtual nint Mj_totalDataCount {
		[Export ("mj_totalDataCount")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("mj_totalDataCount"));
			} else {
				return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_totalDataCount"));
			}
		}
		
	}
	
} /* class UIScrollView_MJRefresh */
