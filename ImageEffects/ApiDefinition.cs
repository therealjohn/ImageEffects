using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace ImageEffects {

	[Category, BaseType (typeof (UIImage))]
	public partial interface ImageEffects_UIImage {

		[Export ("applyLightEffect")]
		UIImage ApplyLightEffect ();

		[Export ("applyExtraLightEffect")]
		UIImage ApplyExtraLightEffect ();

		[Export ("applyDarkEffect")]
		UIImage ApplyDarkEffect ();

		[Export ("applyTintEffectWithColor")]
		UIImage ApplyTintEffectWithColor (UIColor tintColor);

		[Export ("applyBlurWithRadius:tintColor:saturationDeltaFactor:maskImage:")]
		UIImage ApplyBlurWithRadius (float blurRadius, UIColor tintColor, float saturationDeltaFactor, [NullAllowed]UIImage maskImage);
	}
}
