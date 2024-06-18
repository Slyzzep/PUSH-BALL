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
        // Ініціалізуємо початкові координати при запуску
        lastCoordinates = ball.transform.position;
    }

    void Update()
    {
        // Отримуємо поточні координати
        Vector2 currentCoordinates = ball.transform.position;

        // Перевіряємо, чи пройшло достатньо часу для нового запису
        if (Time.time >= recordInterval)
        {
            // Записуємо останні координати
            RecordCoordinates(lastCoordinates);

            // Оновлюємо час для наступного запису
            recordInterval += 5f;
        }

        // Оновлюємо останні координати
        lastCoordinates = currentCoordinates;

       
    }

    void RecordCoordinates(Vector2 coordinates)
    {
        // Записуємо останні координати в консоль (можеш змінити цю частину за своїми потребами)
        currentCoordinates = coordinates;
    }

    public void PressReviveButton()
    {   
        ball.transform.position = currentCoordinates;     
    }
}
