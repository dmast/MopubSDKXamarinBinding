using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;
using MonoTouch.CoreVideo;
using MonoTouch.AVFoundation;
using MonoTouch.MediaPlayer;
using MonoTouch.StoreKit;
using MonoTouch.CoreMedia;
using MonoTouch.EventKit;
using MonoTouch.EventKitUI;
using MonoTouch.Foundation;

[assembly: LinkWith ("libMoPubSDK-armv7.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, Frameworks = "AdSupport CoreGraphics CoreTelephony EventKit EventKitUI Foundation MediaPlayer QuartzCore StoreKit SystemConfiguration UIKit AudioToolbox AVFoundation iAd MessageUI MobileCoreServices PassKit Social")]
