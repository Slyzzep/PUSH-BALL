using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialStart : MonoBehaviour
{
    [SerializeField] GameObject _textOne;
    [SerializeField] GameObject _imageOne;
    [SerializeField] GameObject _imageTwo;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Time.timeScale = 1f;
            Destroy(_textOne);
            Destroy(_imageOne);
            Destroy(_imageTwo);
            Destroy(gameObject);
        }
    }
}
