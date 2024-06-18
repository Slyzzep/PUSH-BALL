using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finishTriger : MonoBehaviour
{
    public int currentLevel;
    [SerializeField] GameObject taps;
    [SerializeField] GameObject finishMenu;
    [SerializeField] GameObject pauseButton;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Time.timeScale = 0f;
            finishMenu.SetActive(true);
            taps.SetActive(false);
            pauseButton.SetActive(false);
        }
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            finishMenu.SetActive(true);
            taps.SetActive(false);
            pauseButton.SetActive(false);
        }
        Pass();
    }
    public void Pass()
    {
        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlock"))
        {
            PlayerPrefs.SetInt("levelsUnlock", currentLevel + 1);
        }
        Debug.Log("Level" + PlayerPrefs.GetInt("levelsUnlock") + "UnLocked");
    }
    
}
