using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTen : MonoBehaviour
{
    
    public adsAfterTen _adsFirst;
    public AdsInitializer _adsSecond;

    // Start is called before the first frame update
    void Start()
    {
        _adsSecond.InitializeAds();
        int count = PlayerPrefs.GetInt("AdsCount", 0);
      
    }
    public void countplus()
    {
        int count = PlayerPrefs.GetInt("AdsCount", 0);
        count++;
    
        PlayerPrefs.SetInt("AdsCount", count);
        PlayerPrefs.Save();
        if (count >= 3)
        {
            Load();
            count = 0;

            PlayerPrefs.SetInt("AdsCount", count);
            PlayerPrefs.Save();

        }
    }
    public void Load()  
    {
        _adsFirst.LoadAd();
        _adsFirst.ShowAd();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
