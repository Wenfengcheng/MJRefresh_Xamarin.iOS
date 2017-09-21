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

public unsafe static partial class UILabel_MJRefresh  {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("UILabel");
	
	[Export ("mj_label")]
	[CompilerGenerated]
	public static global::UIKit.UILabel Mj_label (this global::UIKit.UILabel This)
	{
		return  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("mj_label")));
	}
	
	[CompilerGenerated]
	public virtual nfloat Mj_textWith {
		[Export ("mj_textWith")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("mj_textWith"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mj_textWith"));
			}
		}
		
	}
	
} /* class UILabel_MJRefresh */
