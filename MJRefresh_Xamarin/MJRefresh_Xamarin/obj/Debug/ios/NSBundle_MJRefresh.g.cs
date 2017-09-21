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

public unsafe static partial class NSBundle_MJRefresh  {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("NSBundle");
	
	[Export ("mj_localizedStringForKey:value:")]
	[CompilerGenerated]
	public static string Mj_localizedStringForKey (this NSBundle This, string key, string value)
	{
		if (key == null)
			throw new ArgumentNullException ("key");
		if (value == null)
			throw new ArgumentNullException ("value");
		var nskey = NSString.CreateNative (key);
		var nsvalue = NSString.CreateNative (value);
		
		string ret;
		ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("mj_localizedStringForKey:value:"), nskey, nsvalue));
		NSString.ReleaseNative (nskey);
		NSString.ReleaseNative (nsvalue);
		
		return ret;
	}
	
	[Export ("mj_localizedStringForKey:")]
	[CompilerGenerated]
	public static string Mj_localizedStringForKey (this NSBundle This, string key)
	{
		if (key == null)
			throw new ArgumentNullException ("key");
		var nskey = NSString.CreateNative (key);
		
		string ret;
		ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("mj_localizedStringForKey:"), nskey));
		NSString.ReleaseNative (nskey);
		
		return ret;
	}
	
	[Export ("mj_refreshBundle")]
	[CompilerGenerated]
	public static NSBundle Mj_refreshBundle (this NSBundle This)
	{
		return  Runtime.GetNSObject<NSBundle> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("mj_refreshBundle")));
	}
	
	[CompilerGenerated]
	public static global::UIKit.UIImage Mj_arrowImage {
		[Export ("mj_arrowImage")]
		get {
			global::UIKit.UIImage ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("mj_arrowImage")));
			return ret;
		}
		
	}
	
} /* class NSBundle_MJRefresh */
