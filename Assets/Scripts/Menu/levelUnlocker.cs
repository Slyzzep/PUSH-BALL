using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelUnlocker : MonoBehaviour
{
    int levelsUnclock;
    public Button[] buttons;

    void Start()
    {
        levelsUnclock = PlayerPrefs.GetInt("levelsUnlock", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelsUnclock; i++)
        {
            buttons[i].interactable = true;
        }
    }

   
    void Update()
    {
        
    }
}
