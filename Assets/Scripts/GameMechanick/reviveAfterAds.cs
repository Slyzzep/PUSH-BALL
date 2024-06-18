using System.Collections;
using System.Collections.Generic;
//using UnityEditor.AnimatedValues;
using UnityEngine;

public class MyOtherScript : MonoBehaviour
{
    [SerializeField] GameObject taps;
    [SerializeField] GameObject lose;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject ball;

    public Animator _reviveAnimation;
    public string _tagFirst = "Ball";
    public string _tagSecond = "Player";

    public bool anim = false;

    private Rigidbody2D ballRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody2D>();
      //  _reviveAnimation = GetComponent<Animator>();
        
    }

    public void ReviveReward()
    {
        ballRigidbody.velocity = Vector2.zero;
        Time.timeScale = 1f;
        MoveLoseMenuToCoordinates(0, -3500, 0);
        taps.SetActive(true);
        pauseButton.SetActive(true);
        ball.tag = _tagSecond;
        _reviveAnimation.SetBool("_revive", true);
        Invoke("continueRevive", 5f);


    }

    public void continueRevive()
    {
        ball.tag = _tagFirst;
        _reviveAnimation.SetBool("_revive", false);
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void MoveLoseMenuToCoordinates(float x, float y, float z)
    {
        // ѕерев≥р€Їмо, чи RectTransform не дор≥внюЇ null
        if (lose.GetComponent<RectTransform>() != null)
        {
            // «м≥нюЇмо позиц≥ю loseMenu
            lose.GetComponent<RectTransform>().anchoredPosition = new Vector3(x, y, z);
        }
        else
        {
            Debug.LogError("LoseMenu RectTransform not found!");
        }
    }
}
