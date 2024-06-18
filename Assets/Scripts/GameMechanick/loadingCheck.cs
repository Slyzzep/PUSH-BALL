using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingCheck : MonoBehaviour
{
   
    
    [SerializeField] GameObject _start;
    [SerializeField] GameObject _taps;
    
    public AdsInitializer _adsLoadFirst;
    public RewardedAdsButton _adsLoadSecond;
    void Start()
    {
       
        

        if (Application.internetReachability != NetworkReachability.NotReachable)
        {

            _adsLoadFirst.InitializeAds();
            _adsLoadSecond.LoadAd();
            _taps.SetActive(false);
            Invoke("Load", 1.5f);
            

        }

        else
        {
            _taps.SetActive(false);
            Invoke("Load", 1f);
        }
    }
    public void Load()
    {
        _taps.SetActive(true);
        
        _start.SetActive(true);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
