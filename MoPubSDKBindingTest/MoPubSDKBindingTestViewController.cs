using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using MoPubSDK_ARMv7;
namespace MoPubSDKBindingTest

/**

**/
{
	public partial class MoPubSDKBindingTestViewController : UIViewController
	{
		//Put your ad unit ids here
		static string MOPUB_BANNER_ADUNIT_ID = "***************";
		static string MOPUB_INTERSTITIAL_ADUNIT_ID = "****************";
		public MoPubSDKBindingTestViewController () : base ("MoPubSDKBindingTestViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}


		void LoadBannerAds ()
		{
			// Perform any additional setup after loading the view, typically from a nib.
			SizeF size = new SizeF (320, 50);
			//CGRectMake(0, self.view.bounds.size.height - MOPUB_BANNER_SIZE.height, MOPUB_BANNER_SIZE.width, MOPUB_BANNER_SIZE.height);
			MPAdView _mpAdView = new MPAdView (MOPUB_BANNER_ADUNIT_ID, size);
			_mpAdView.Frame = new RectangleF (0,50, 320, 50);
			_mpAdView.LoadAd ();
			_mpAdView.Delegate = new MopubBannerAdDelegate (this);
			this.Add (_mpAdView);
		}

		void LoadInterstitial ()
		{
			MPInterstitialAdController interstial = new MPInterstitialAdController ();
			interstial = MPInterstitialAdController.InterstitialAdControllerForAdUnitId (MOPUB_INTERSTITIAL_ADUNIT_ID);
			interstial.Delegate = new MopubInterstitialAdDelegate (this);
			interstial.LoadAd ();
		}

		void LoadInterstitialView()
		{
			//LoadInterstitial ();
			var btnLoadInterstital = UIButton.FromType (UIButtonType.RoundedRect);
			btnLoadInterstital.SetTitle ("Load Interstital", UIControlState.Normal);
			btnLoadInterstital.Frame = new RectangleF (0, UIScreen.MainScreen.Bounds.Height - 50, 320, 50);
			btnLoadInterstital.TouchUpInside += delegate {
				LoadInterstitial();
			};
			this.Add (btnLoadInterstital);
			


		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			LoadInterstitialView ();
			//this.LoadBannerAds ();
		}

	}

}

