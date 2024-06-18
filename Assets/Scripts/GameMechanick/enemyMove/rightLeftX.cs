using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightLeftX : MonoBehaviour
{

    public float speed;
    public Vector2 leftPosition;
    public Vector2 rightPosition;

    private bool movingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movingRight)
        {
            // Move towards the right position
            transform.position = Vector2.MoveTowards(transform.position, rightPosition, speed * Time.deltaTime);

            // Check if the object has reached the right position
            if ((Vector2)transform.position == rightPosition)
            {
                movingRight = false;
            }
        }
        else
        {
            // Move towards the left position
            transform.position = Vector2.MoveTowards(transform.position, leftPosition, speed * Time.deltaTime);

            // Check if the object has reached the left position
            if ((Vector2)transform.position == leftPosition)
            {
                movingRight = true;
            }
        }
    }
}

