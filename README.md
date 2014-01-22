MopubSDKXamarinBinding
======================

Binding example with Xamarin and MoPub SDK 1.7
<br/>
!! Note, due to bugs in Xamarin iOS, the "Fat" binary binding does not work so you have to include the MoPubSDK_i386.a file for Simulator, 
or the MoPubSDK_ARMv7.a file for device testing in your main xamarin project
To use : 
<br/>
1) Add a reference to either the MoPubSDK_i386, or MoPubSDK_ARMv7 in your main Xamarin project
<br/>
2) Import appropriate name space (MoPubSDK_i386, or MoPubSDK_ARMv7)
<br/>
3) Testing code


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
