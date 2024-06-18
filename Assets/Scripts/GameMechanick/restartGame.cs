using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject loseMenu;
    [SerializeField] GameObject taps;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Ball")) 
        {
            Time.timeScale = 0f;
            //loseMenu.SetActive(true);
            MoveLoseMenuToCoordinates(0, -250, 0);
            taps.SetActive(false);
            pauseButton.SetActive(false);

        }
    }
    private void RestartScene()
    {
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        
        taps.SetActive(true);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }
    private void MoveLoseMenuToCoordinates(float x, float y, float z)
    {
        // ѕерев≥р€Їмо, чи RectTransform не дор≥внюЇ null
        if (loseMenu.GetComponent<RectTransform>() != null)
        {
            // «м≥нюЇмо позиц≥ю loseMenu
            loseMenu.GetComponent<RectTransform>().anchoredPosition = new Vector3(x, y, z);
        }
        else
        {
            Debug.LogError("LoseMenu RectTransform not found!");
        }
    }
}
