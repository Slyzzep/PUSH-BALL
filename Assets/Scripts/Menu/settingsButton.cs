using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsButton : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject settings;
    [SerializeField] GameObject levels;
    [SerializeField] GameObject backfromsettings;

    public void pressSettings()
    {
        settings.SetActive(true);
        menu.SetActive(false);

    }
    public void pressBack()
    {
        settings.SetActive(false);
        levels.SetActive(false);
        menu.SetActive(true);
    }
    public void pressLevels()
    {
        levels.SetActive(true);
        settings.SetActive(false);
        menu.SetActive(false);

    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
