using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMoPubSDK-i386.a", LinkTarget.Simulator, ForceLoad = true, Frameworks = "AdSupport CoreGraphics CoreTelephony EventKit EventKitUI Foundation MediaPlayer QuartzCore StoreKit SystemConfiguration UIKit AudioToolbox AVFoundation iAd MessageUI MobileCoreServices PassKit Social")]
