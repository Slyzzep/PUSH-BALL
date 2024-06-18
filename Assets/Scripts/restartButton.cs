using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour
{
    [SerializeField] GameObject restartButtonpress;

    public void restartGame()
    {
        restartButtonpress.SetActive(true);
        RestartScene();
        Time.timeScale = 1f;
    }
        private void RestartScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;


        SceneManager.LoadScene(currentSceneIndex);
    }
    
}
