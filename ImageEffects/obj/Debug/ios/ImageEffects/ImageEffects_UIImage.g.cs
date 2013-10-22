//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace ImageEffects {
	public unsafe static partial class ImageEffects_UIImage  {
		[CompilerGenerated]
		const string selApplyLightEffect = "applyLightEffect";
		static readonly IntPtr selApplyLightEffectHandle = Selector.GetHandle ("applyLightEffect");
		[CompilerGenerated]
		const string selApplyExtraLightEffect = "applyExtraLightEffect";
		static readonly IntPtr selApplyExtraLightEffectHandle = Selector.GetHandle ("applyExtraLightEffect");
		[CompilerGenerated]
		const string selApplyDarkEffect = "applyDarkEffect";
		static readonly IntPtr selApplyDarkEffectHandle = Selector.GetHandle ("applyDarkEffect");
		[CompilerGenerated]
		const string selApplyTintEffectWithColor = "applyTintEffectWithColor";
		static readonly IntPtr selApplyTintEffectWithColorHandle = Selector.GetHandle ("applyTintEffectWithColor");
		[CompilerGenerated]
		const string selApplyBlurWithRadius = "applyBlurWithRadius";
		static readonly IntPtr selApplyBlurWithRadiusHandle = Selector.GetHandle ("applyBlurWithRadius");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::MonoTouch.UIKit.UIImage");
		
		[Export ("applyLightEffect")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIImage ApplyLightEffect (this global::MonoTouch.UIKit.UIImage This)
		{
			return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, selApplyLightEffectHandle));
		}
		
		[Export ("applyExtraLightEffect")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIImage ApplyExtraLightEffect (this global::MonoTouch.UIKit.UIImage This)
		{
			return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, selApplyExtraLightEffectHandle));
		}
		
		[Export ("applyDarkEffect")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIImage ApplyDarkEffect (this global::MonoTouch.UIKit.UIImage This)
		{
			return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, selApplyDarkEffectHandle));
		}
		
		[Export ("applyTintEffectWithColor")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIImage ApplyTintEffectWithColor (this global::MonoTouch.UIKit.UIImage This, global::MonoTouch.UIKit.UIColor tintColor)
		{
			if (tintColor == null)
				throw new ArgumentNullException ("tintColor");
			return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, selApplyTintEffectWithColorHandle, tintColor.Handle));
		}
		
		[Export ("applyBlurWithRadius")]
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIImage ApplyBlurWithRadius (this global::MonoTouch.UIKit.UIImage This, float blurRadius, global::MonoTouch.UIKit.UIColor tintColor, float saturationDeltaFactor, global::MonoTouch.UIKit.UIImage maskImage)
		{
			if (tintColor == null)
				throw new ArgumentNullException ("tintColor");
			return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSend_float_IntPtr_float_IntPtr (This.Handle, selApplyBlurWithRadiusHandle, blurRadius, tintColor.Handle, saturationDeltaFactor, maskImage == null ? IntPtr.Zero : maskImage.Handle));
		}
		
	} /* class ImageEffects_UIImage */
}
