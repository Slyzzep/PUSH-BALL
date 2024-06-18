using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class tapPush : MonoBehaviour
{
    [SerializeField] public AudioSource SFXSource;
    public AudioClip push;
    public float repelForceMagnitude = 100f;
    //---------------------------------------
    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D otherRigidbody = other.GetComponent<Rigidbody2D>();
        if (otherRigidbody != null)
        {     
            //Визначення напрямку поштовху
            Vector2 repelDirection = (other.transform.position - transform.position).normalized;
            //Обчислення сили поштовху
            Vector2 repelForce = repelDirection * repelForceMagnitude;
            //Вплив поштовху на об'єкт м'яча
            otherRigidbody.AddForce(repelForce, ForceMode2D.Impulse);
            //Звук поштовху
            SFXSource.clip = push;
            SFXSource.Play();
        }
    }
}
