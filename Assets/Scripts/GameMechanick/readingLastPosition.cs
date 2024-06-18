using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readingLastPosition : MonoBehaviour
{
    private Vector2 currentCoordinates;
    private Vector2 lastCoordinates;
    private float recordInterval = 5f;
    [SerializeField] GameObject ball;

    void Start()
    {
        // ���������� �������� ���������� ��� �������
        lastCoordinates = ball.transform.position;
    }

    void Update()
    {
        // �������� ������ ����������
        Vector2 currentCoordinates = ball.transform.position;

        // ����������, �� ������� ��������� ���� ��� ������ ������
        if (Time.time >= recordInterval)
        {
            // �������� ������ ����������
            RecordCoordinates(lastCoordinates);

            // ��������� ��� ��� ���������� ������
            recordInterval += 5f;
        }

        // ��������� ������ ����������
        lastCoordinates = currentCoordinates;

       
    }

    void RecordCoordinates(Vector2 coordinates)
    {
        // �������� ������ ���������� � ������� (����� ������ �� ������� �� ����� ���������)
        currentCoordinates = coordinates;
    }

    public void PressReviveButton()
    {   
        ball.transform.position = currentCoordinates;     
    }
}
