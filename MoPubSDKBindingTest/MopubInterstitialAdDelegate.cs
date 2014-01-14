using System;
using MoPubSDKBindingTest;
using MonoTouch.UIKit;
using MoPubSDK_ARMv7;

namespace MoPubSDKBindingTest
{
	public class MopubInterstitialAdDelegate : MPInterstitialAdControllerDelegate
	{
		MoPubSDKBindingTestViewController controller;
		public MopubInterstitialAdDelegate (MoPubSDKBindingTestViewController vc)
		{
			Console.WriteLine("Delegate loaded");
			controller = vc;

		}
		public override void InterstitialDidLoadAd(MPInterstitialAdController interstitial)
		{
			Console.WriteLine ("Loading interstitials with AdUnitID = " + interstitial.AdUnitId);
			interstitial.ShowFromViewController (controller);
		}
		public override void InterstitialDidFailToLoadAd(MPInterstitialAdController interstitial)
		{
			Console.WriteLine ("Interstitial failed to load");
		}
		public override void InterstitialWillAppear (MPInterstitialAdController interstitial)
		{
			Console.WriteLine ("Interstitial will appear");
		}

		public override void InterstitialWillDisappear (MPInterstitialAdController interstitial)
		{
			Console.WriteLine ("View Will disappear");
		}
		public override void InterstitialDidDisappear (MPInterstitialAdController interstitial)
		{
			Console.WriteLine ("View did disappear");
		}

		public override void DismissInterstitial (MPInterstitialAdController interstitial)
		{
			Console.WriteLine ("View did Dismiss");
		}

	}
}

