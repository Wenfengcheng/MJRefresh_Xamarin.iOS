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

public unsafe static partial class UIView_MJExtension  {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("UIView");
	
	[CompilerGenerated]
	public virtual nfloat Mj_h {
		[Export ("mj_h")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("mj_h"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_h"));
			}
		}
		
		[Export ("setMj_h:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMj_h:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMj_h:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual CGPoint Mj_origin {
		[Export ("mj_origin", ArgumentSemantic.UnsafeUnretained)]
		get {
			CGPoint ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("mj_origin"));
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("mj_origin"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("mj_origin"));
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("mj_origin"));
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_origin"));
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("mj_origin"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_origin"));
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_origin"));
				}
			}
			return ret;
		}
		
		[Export ("setMj_origin:", ArgumentSemantic.UnsafeUnretained)]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setMj_origin:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setMj_origin:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual CGSize Mj_size {
		[Export ("mj_size", ArgumentSemantic.UnsafeUnretained)]
		get {
			CGSize ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("mj_size"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("mj_size"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("mj_size"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("mj_size"));
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_size"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("mj_size"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_size"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_size"));
				}
			}
			return ret;
		}
		
		[Export ("setMj_size:", ArgumentSemantic.UnsafeUnretained)]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setMj_size:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("setMj_size:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual nfloat Mj_w {
		[Export ("mj_w")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("mj_w"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_w"));
			}
		}
		
		[Export ("setMj_w:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMj_w:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMj_w:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual nfloat Mj_x {
		[Export ("mj_x")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("mj_x"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_x"));
			}
		}
		
		[Export ("setMj_x:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMj_x:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMj_x:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual nfloat Mj_y {
		[Export ("mj_y")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("mj_y"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_y"));
			}
		}
		
		[Export ("setMj_y:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMj_y:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMj_y:"), value);
			}
		}
	}
	
} /* class UIView_MJExtension */
