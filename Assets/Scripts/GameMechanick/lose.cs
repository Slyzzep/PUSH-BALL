using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose : MonoBehaviour
{
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject loseMenu;
    [SerializeField] GameObject taps;
    
    void Start()
    {
    }
    public void losetrue()
    {
        Time.timeScale = 0f;
        MoveLoseMenuToCoordinates(0, -250, 0);
        taps.SetActive(false);
        pauseButton.SetActive(false);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
