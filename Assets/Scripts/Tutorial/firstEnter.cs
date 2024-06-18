using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstEnter : MonoBehaviour
{
    //public bool _first;
    void Start()
    {
        //bool _first = PlayerPrefs.Getbool("ff", true);
       int _first = PlayerPrefs.GetInt("Tutor", 1);
        if (_first==1)
        {
            _first = 0;
            PlayerPrefs.SetInt("Tutor", _first);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Tutorial");
        }
    else
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        
    }
}
