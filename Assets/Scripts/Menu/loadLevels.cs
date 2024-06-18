using System.Collections;
using System.Collections.Generic;
using UnityEditor;

using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevels : MonoBehaviour
{
    [SerializeField] public string scene;
    public void  pressLevelButton()
    {

        SceneManager.LoadScene(scene);
        Time.timeScale = 1f;

    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
