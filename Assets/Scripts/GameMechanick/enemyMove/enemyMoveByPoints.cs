using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class enemyMoveByPoints : MonoBehaviour
{

    public Vector2[] point;
    [Header("----------------------------------------------------------------------------------------")]
    public float speed;
    private int currentPointIndex = 0;

    int numbOfArray;
    
    // Start is called before the first frame update
    void Start()
    {
        int arrayLength = point.Length;
        numbOfArray = arrayLength;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentPointIndex < point.Length)
        {
            // �������� �� ������� �����
            transform.position = Vector2.MoveTowards(transform.position, point[currentPointIndex], speed * Time.deltaTime);

            // ��������, �� �� ��� ������� ������� �����
            if (Vector2.Distance(transform.position, point[currentPointIndex]) < 0.1f)
            {
                // ���� �������, �������� ������, ��� �������� �� �������� �����
                currentPointIndex++;

               if(currentPointIndex >= numbOfArray)
                {
                    Debug.Log(currentPointIndex);
                   
                    currentPointIndex = 0;
                     }


                }
            }
        }
       
    }


