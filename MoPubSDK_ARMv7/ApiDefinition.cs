using System.Drawing;
using System;
using MonoTouch.Foundation;
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

namespace MoPubSDK_ARMv7 {

	[Model, BaseType (typeof (NSObject))]
	public partial interface MPInterstitialCustomEventDelegate {

		[Export ("location")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPInterstitialCustomEventDelegate.h", Line = 34)]
		CLLocation Location { get; }

		[Export ("interstitialCustomEvent:didLoadAd:")]
		void DidLoadAd (MPInterstitialCustomEvent customEvent, NSObject ad);

		[Export ("interstitialCustomEvent:didFailToLoadAdWithError:")]
		void DidFailToLoadAdWithError (MPInterstitialCustomEvent customEvent, NSError error);

		[Export ("interstitialCustomEventDidExpire:")]
		void InterstitialCustomEventDidExpire (MPInterstitialCustomEvent customEvent);

		[Export ("interstitialCustomEventWillAppear:")]
		void InterstitialCustomEventWillAppear (MPInterstitialCustomEvent customEvent);

		[Export ("interstitialCustomEventDidAppear:")]
		void InterstitialCustomEventDidAppear (MPInterstitialCustomEvent customEvent);

		[Export ("interstitialCustomEventWillDisappear:")]
		void InterstitialCustomEventWillDisappear (MPInterstitialCustomEvent customEvent);

		[Export ("interstitialCustomEventDidDisappear:")]
		void InterstitialCustomEventDidDisappear (MPInterstitialCustomEvent customEvent);

		[Export ("interstitialCustomEventDidReceiveTapEvent:")]
		void InterstitialCustomEventDidReceiveTapEvent (MPInterstitialCustomEvent customEvent);

		[Export ("interstitialCustomEventWillLeaveApplication:")]
		void InterstitialCustomEventWillLeaveApplication (MPInterstitialCustomEvent customEvent);

		[Export ("trackImpression")]
		void TrackImpression ();

		[Export ("trackClick")]
		void TrackClick ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface MPInterstitialCustomEvent {

		[Export ("requestInterstitialWithCustomEventInfo:")]
		void RequestInterstitialWithCustomEventInfo (NSDictionary info);

		[Export ("showInterstitialFromRootViewController:")]
		void ShowInterstitialFromRootViewController (UIViewController rootViewController);

		[Export ("enableAutomaticImpressionAndClickTracking")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPInterstitialCustomEvent.h", Line = 72)]
		bool EnableAutomaticImpressionAndClickTracking { get; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		MPInterstitialCustomEventDelegate Delegate { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface MPReachability {

		[Static, Export ("reachabilityForLocalWiFi")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/Internal/Utility/MPReachability.h", Line = 58)]
		MPReachability ReachabilityForLocalWiFi { get; }

		[Export ("hasWifi")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/Internal/Utility/MPReachability.h", Line = 59)]
		bool HasWifi { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface MRVideoPlayerManager {

		[Export ("delegate", ArgumentSemantic.Assign)]
		MRVideoPlayerManagerDelegate Delegate { get; set; }

		[Export ("initWithDelegate:")]
		IntPtr Constructor (MRVideoPlayerManagerDelegate mr_delegate);

		[Export ("playVideo:")]
		void PlayVideo (NSDictionary parameters);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface MRVideoPlayerManagerDelegate {

		[Export ("viewControllerForPresentingVideoPlayer")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/Internal/MRAID/MRVideoPlayerManager.h", Line = 20)]
		UIViewController ViewControllerForPresentingVideoPlayer { get; }

		[Export ("videoPlayerManagerWillPresentVideo:")]
		void VideoPlayerManagerWillPresentVideo (MRVideoPlayerManager manager);

		[Export ("videoPlayerManagerDidDismissVideo:")]
		void VideoPlayerManagerDidDismissVideo (MRVideoPlayerManager manager);

		[Export ("videoPlayerManager:didFailToPlayVideoWithErrorMessage:")]
		void DidFailToPlayVideoWithErrorMessage (MRVideoPlayerManager manager, string message);
	}



	[BaseType (typeof (UIView))]
	public partial interface MPAdView {

		[Export ("initWithAdUnitId:size:")]
		IntPtr Constructor (string adUnitId, SizeF size);

		[Export ("delegate", ArgumentSemantic.Assign)]
		MPAdViewDelegate Delegate { get; set; }

		[Export ("adUnitId", ArgumentSemantic.Copy)]
		string AdUnitId { get; set; }

		[Export ("keywords", ArgumentSemantic.Retain)]
		string Keywords { get; set; }

		[Export ("location", ArgumentSemantic.Copy)]
		CLLocation Location { get; set; }

		[Export ("testing")]
		bool Testing { [Bind ("isTesting")] get; set; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("refreshAd")]
		void RefreshAd ();

		[Export ("forceRefreshAd")]
		void ForceRefreshAd ();

		[Export ("rotateToOrientation:")]
		void RotateToOrientation (UIInterfaceOrientation newOrientation);

		[Export ("lockNativeAdsToOrientation:")]
		void LockNativeAdsToOrientation (MPNativeAdOrientation orientation);

		[Export ("unlockNativeAdsOrientation")]
		void UnlockNativeAdsOrientation ();

		[Export ("allowedNativeAdsOrientation")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPAdView.h", Line = 173)]
		MPNativeAdOrientation AllowedNativeAdsOrientation { get; }

		[Export ("adContentViewSize")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPAdView.h", Line = 187)]
		SizeF AdContentViewSize { get; }

		[Export ("stopAutomaticallyRefreshingContents")]
		void StopAutomaticallyRefreshingContents ();

		[Export ("startAutomaticallyRefreshingContents")]
		void StartAutomaticallyRefreshingContents ();

		[Export ("customEventDidLoadAd")]
		void CustomEventDidLoadAd ();

		[Export ("customEventDidFailToLoadAd")]
		void CustomEventDidFailToLoadAd ();

		[Export ("customEventActionWillBegin")]
		void CustomEventActionWillBegin ();

		[Export ("customEventActionDidEnd")]
		void CustomEventActionDidEnd ();

		[Export ("adContentView")]// ("ObjC method massaged into setter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPAdView.h", Line = 265)]
		UIView AdContentView { set; }

		[Export ("ignoresAutorefresh")]
		bool IgnoresAutorefresh { get; set; }
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface MPAdViewDelegate {

		[Export ("viewControllerForPresentingModalView")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPAdView.h", Line = 310)]
		UIViewController ViewControllerForPresentingModalView { get; }

		[Export ("adViewDidLoadAd:")]
		void AdViewDidLoadAd (MPAdView view);

		[Export ("adViewDidFailToLoadAd:")]
		void adViewDidFailToLoadAd (MPAdView view);

		[Export ("willPresentModalViewForAd:")]
		void WillPresentModalViewForAd (MPAdView view);

		[Export ("didDismissModalViewForAd:")]
		void DidDismissModalViewForAd (MPAdView view);

		[Export ("willLeaveApplicationFromAd:")]
		void WillLeaveApplicationFromAd (MPAdView view);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface MPBannerCustomEventDelegate {

		[Export ("viewControllerForPresentingModalView")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPBannerCustomEventDelegate.h", Line = 31)]
		UIViewController ViewControllerForPresentingModalView { get; }

		[Export ("location")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPBannerCustomEventDelegate.h", Line = 42)]
		CLLocation Location { get; }

		[Export ("bannerCustomEvent:didLoadAd:")]
		void DidLoadAd (MPBannerCustomEvent mp_event, UIView ad);

		[Export ("bannerCustomEvent:didFailToLoadAdWithError:")]
		void DidFailToLoadAdWithError (MPBannerCustomEvent mp_event, NSError error);

		[Export ("bannerCustomEventWillBeginAction:")]
		void BannerCustomEventWillBeginAction (MPBannerCustomEvent mp_vent);

		[Export ("bannerCustomEventDidFinishAction:")]
		void BannerCustomEventDidFinishAction (MPBannerCustomEvent mp_event);

		[Export ("bannerCustomEventWillLeaveApplication:")]
		void BannerCustomEventWillLeaveApplication (MPBannerCustomEvent mp_event);

		[Export ("trackImpression")]
		void TrackImpression ();

		[Export ("trackClick")]
		void TrackClick ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface MPBannerCustomEvent {

		[Export ("requestAdWithSize:customEventInfo:")]
		void RequestAdWithSize (SizeF size, NSDictionary info);

		[Export ("rotateToOrientation:")]
		void RotateToOrientation (UIInterfaceOrientation newOrientation);

		[Export ("didDisplayAd")]
		void DidDisplayAd ();

		[Export ("enableAutomaticImpressionAndClickTracking")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPBannerCustomEvent.h", Line = 80)]
		bool EnableAutomaticImpressionAndClickTracking { get; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		MPBannerCustomEventDelegate Delegate { get; set; }
	}



	[BaseType (typeof (UIViewController))]
	public partial interface MPInterstitialAdController {

		[Static, Export ("interstitialAdControllerForAdUnitId:")]
		MPInterstitialAdController InterstitialAdControllerForAdUnitId (string adUnitId);

		[Export ("delegate", ArgumentSemantic.Assign)]
		MPInterstitialAdControllerDelegate Delegate { get; set; }

		[Export ("adUnitId", ArgumentSemantic.Copy)]
		string AdUnitId { get; set; }

		[Export ("keywords", ArgumentSemantic.Copy)]
		string Keywords { get; set; }

		[Export ("location", ArgumentSemantic.Copy)]
		CLLocation Location { get; set; }

		[Export ("testing")]
		bool Testing { [Bind ("isTesting")] get; set; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("ready")]
		bool Ready { get; }

		[Export ("showFromViewController:")]
		void ShowFromViewController (UIViewController controller);

		[Static, Export ("removeSharedInterstitialAdController:")]
		void RemoveSharedInterstitialAdController (MPInterstitialAdController controller);

		[Static, Export ("sharedInterstitialAdControllers")]// ("ObjC method massaged into getter property", "/Users/dmast/Documents/sdks/mopub-ios-sdk-1.7/mopub-ios-sdk/MoPubSDK/MPInterstitialAdController.h", Line = 146)]
		NSMutableArray SharedInterstitialAdControllers { get; }

		[Export ("customEventDidLoadAd")]
		void CustomEventDidLoadAd ();

		[Export ("customEventDidFailToLoadAd")]
		void CustomEventDidFailToLoadAd ();

		[Export ("customEventActionWillBegin")]
		void CustomEventActionWillBegin ();
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface MPInterstitialAdControllerDelegate {

		[Export ("interstitialDidLoadAd:")]
		void InterstitialDidLoadAd (MPInterstitialAdController interstitial);

		[Export ("interstitialDidFailToLoadAd:")]
		void InterstitialDidFailToLoadAd (MPInterstitialAdController interstitial);

		[Export ("interstitialWillAppear:")]
		void InterstitialWillAppear (MPInterstitialAdController interstitial);

		[Export ("interstitialDidAppear:")]
		void InterstitialDidAppear (MPInterstitialAdController interstitial);

		[Export ("interstitialWillDisappear:")]
		void InterstitialWillDisappear (MPInterstitialAdController interstitial);

		[Export ("interstitialDidDisappear:")]
		void InterstitialDidDisappear (MPInterstitialAdController interstitial);

		[Export ("interstitialDidExpire:")]
		void InterstitialDidExpire (MPInterstitialAdController interstitial);

		[Export ("dismissInterstitial:")]
		void DismissInterstitial (MPInterstitialAdController interstitial);
	}


}
