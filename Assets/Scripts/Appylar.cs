using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AppylarAds;

public class Appylar : MonoBehaviour, AppylarInitializationListener, AppylarInsterstitialListener, AppylarBannerListener
{
    private string appKey;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        AppylarAd.Initialize(GetAppKey()
        , new AdType[]{
                AdType.INTERSTITIAL, AdType.BANNER
            }
            , true
            , this
            );
    }

    private string GetAppKey()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            return appKey = "jrctNFE1b-7IqHPShB-gKw";
        }
        else
        {
            return appKey = "OwDmESooYtY2kNPotIuhiQ";
        }
    }

    public void Interstitial()
    {
        AppylarAd.ShowInterstitial(" ", this);
    }

    public void ShowBanner()
    {
        AppylarAd.ShowBanner(BannerPosition.BOTTOM, " ", this);
    }

    public void HideBanner()
    {
        AppylarAd.HideBanner();
    }

    #region Interface Implementations
    public void onNoBanner()
    {
        print("onNoBanner");
    }

    public void onBannerShown(int height)
    {
        print("onBannerShown " + height);
    }

    public void onInitialized()
    {
        print("onInitialized");
    }

    public void onError(string message)
    {
        print($"onError : {message}");
    }

    public void onNoInterstitial()
    {
        print("onNoInterstitial ");
    }

    public void onInterstitialShown()
    {
        print("onInterstitialShown");
    }

    public void onInterstitialClosed()
    {
        print("onInterstitialClosed ");
    }
    #endregion


}