using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    
    [SerializeField] GameObject _textOne;
    [SerializeField] GameObject _pause;
    [SerializeField] GameObject _circle;
    [SerializeField] GameObject _nearBall;
    void Start()
    {
        Time.timeScale = 0f;
        
    }


    void Update()
    {
        if (Input.touchCount > 0)
        {
            _pause.SetActive(true);
            Time.timeScale = 1f;
            Destroy(gameObject);
            Destroy(_textOne);
            Destroy(_circle);
            Destroy(_nearBall);

        }
    }
}
