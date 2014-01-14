using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using MoPubSDK_ARMv7;
namespace MoPubSDKBindingTest

/**
 * Iphone:
Banner: 28cb14de547f4d67979befa60cfd823f
Interstitial: a1c58c5ac9084eeca746af006c9b4d2c

Ipad
Banner:
667d3144231a4e66918b9b05cd27aea8
Interstitial: 69f51eb881554cea87fe8257d5cb058e

Testing Banner: cdd96554348040eea55a46b59f09a70f
Testing Interstitial: 90b9f4fe5de244a8a86152d3dbd2256c
**/
{
	public partial class MoPubSDKBindingTestViewController : UIViewController
	{
		static string MOPUB_BANNER_ADUNIT_ID = "28cb14de547f4d67979befa60cfd823f";
		static string MOPUB_INTERSTITIAL_ADUNIT_ID = "a1c58c5ac9084eeca746af006c9b4d2c";
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
			_mpAdView.Frame = new RectangleF (0, UIScreen.MainScreen.Bounds.Height - 50, 320, 50);
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
		/**
		 * NSString *adUnitID = @"agltb3B1Yi1pbmNyDQsSBFNpdGUY_rW-Fgw";

- (void)viewDidLoad
{
	self.adView = [[MPAdView alloc] initWithAdUnitId:adUnitID size:MOPUB_BANNER_SIZE];
    self.adView.delegate = self;
    self.adView.frame = CGRectMake(0, self.view.bounds.size.height - MOPUB_BANNER_SIZE.height, MOPUB_BANNER_SIZE.width, MOPUB_BANNER_SIZE.height);
    [self.view addSubview:self.adView];
    [self.adView loadAd];
    [super viewDidLoad];
}

- (UIViewController *)viewControllerForPresentingModalView {
    return self;
}

- (void)adViewDidLoadAd:(MPAdView *)view
{
    CGSize size = [view adContentViewSize];
    CGFloat centeredX = (self.view.bounds.size.width - size.width) / 2;
    CGFloat bottomAlignedY = self.view.bounds.size.height - size.height;
    view.frame = CGRectMake(centeredX, bottomAlignedY, size.width, size.height);
}

- (void)willRotateToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation
                                duration:(NSTimeInterval)duration {
    [self.adView rotateToOrientation:toInterfaceOrientation];
}

- (void)didRotateFromInterfaceOrientation:(UIInterfaceOrientation)fromInterfaceOrientation {
    CGSize size = [self.adView adContentViewSize];
    CGFloat centeredX = (self.view.bounds.size.width - size.width) / 2;
    CGFloat bottomAlignedY = self.view.bounds.size.height - size.height;
    self.adView.frame = CGRectMake(centeredX, bottomAlignedY, size.width, size.height);
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

		**/



