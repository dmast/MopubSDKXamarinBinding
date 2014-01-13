using System;
using MoPubSDK;
using MonoTouch.UIKit;


namespace MoPubSDKBindingTest
{
	public class MopubBannerAdDelegate : MPAdViewDelegate
	{
		MoPubSDKBindingTestViewController controller;
		public MopubBannerAdDelegate (MoPubSDKBindingTestViewController vc)
		{
			Console.WriteLine("Delegate loaded");
			controller = vc;
		}
		public override void AdViewDidLoadAd(MPAdView adView)
		{
			Console.WriteLine ("Adview Loaded");

		}
		/**
		public override void WillPresentModalViewForAd(MPAdView adView)
		{
			Console.WriteLine ("Presenting Modal Ad");
			//base.WillPresentModalViewForAd (adView);
		}
		**/

		public override UIViewController ViewControllerForPresentingModalView {
			get {
				if (controller != null) {
					return controller;
				} else {
					return null;
				}
			}
		}
	}
}

