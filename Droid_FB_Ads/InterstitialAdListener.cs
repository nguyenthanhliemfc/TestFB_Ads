using System;
using Xamarin.Facebook.Ads;

namespace Droid_FB_Ads
{
    internal class InterstitialAdListener : IInterstitialAdListener
    {
        private InterstitialAd interstitialAd;

        public InterstitialAdListener(InterstitialAd interstitialAd)
        {
            this.interstitialAd = interstitialAd;
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public IntPtr Handle { get; }
        public void OnAdClicked(IAd p0)
        {
            Console.WriteLine("OnAdClicked");
        }

        public void OnAdLoaded(IAd p0)
        {
            Console.WriteLine("OnAdLoaded");
            interstitialAd.Show();
        }

        public void OnError(IAd p0, AdError p1)
        {
            Console.WriteLine("OnError " + p1.ErrorMessage);
        }

        public void OnLoggingImpression(IAd p0)
        {
            Console.WriteLine("OnLoggingImpression");
        }

        public void OnInterstitialDismissed(IAd p0)
        {
            Console.WriteLine("OnInterstitialDismissed");
        }

        public void OnInterstitialDisplayed(IAd p0)
        {
            Console.WriteLine("OnInterstitialDisplayed");
        }
    }
}