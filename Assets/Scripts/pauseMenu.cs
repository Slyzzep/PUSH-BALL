using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuObj;
    [SerializeField] GameObject taps;
    public void Pause()
    {
        pauseMenuObj.SetActive(true);
        Time.timeScale = 0f;
        taps.SetActive(false);
    }
    public void Resume()
    {
        pauseMenuObj.SetActive(false);
        Time.timeScale = 1f;
        taps.SetActive(true);
    }
    public void MainMenu(int SceneID) 
    {
        Time.timeScale = 1f;
        taps.SetActive(true);
    }

}
