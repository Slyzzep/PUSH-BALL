using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTutorial : MonoBehaviour
{
    [SerializeField] GameObject _textOne;
    [SerializeField] GameObject _ObjOne;
    [SerializeField] GameObject _camera;
    
   
    bool _ready, _readyToContinue = false;


    public static float unscaledTime;

    public Vector3 _position;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Ball"))
        {
            
            
           
            _textOne.SetActive(true);
            _ObjOne.SetActive(true);
            _ready = true;
            Time.timeScale = 0f;
            _camera.transform.position = _position;
            Debug.Log("Замороження");
            
        }
        if (_ready)
        {
            Debug.Log("Етап затримки");
            Invoke("_rTC",5f);
        }
    }
    public void _rTC()
    {
        Debug.Log("Затримка успішно");
        _readyToContinue = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (_ready)
        {
            if (Time.unscaledTime - unscaledTime >= 1f)
            {
                Debug.Log("Етап затримки пройшов");
                _readyToContinue = true;
            }
        }

        if (Input.touchCount > 0 && _readyToContinue)
        {
            Debug.Log("Розмороження");
            Time.timeScale = 1f;
            _textOne.SetActive(false);
            _ObjOne.SetActive(false);
            Destroy(gameObject);
        }
    }

}
