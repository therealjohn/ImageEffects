using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libImageEffects.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, Frameworks = "ImageIO CoreGraphics Accelerate", ForceLoad = true)]
