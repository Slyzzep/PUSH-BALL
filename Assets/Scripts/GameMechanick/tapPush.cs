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
            //���������� �������� ��������
            Vector2 repelDirection = (other.transform.position - transform.position).normalized;
            //���������� ���� ��������
            Vector2 repelForce = repelDirection * repelForceMagnitude;
            //����� �������� �� ��'��� �'���
            otherRigidbody.AddForce(repelForce, ForceMode2D.Impulse);
            //���� ��������
            SFXSource.clip = push;
            SFXSource.Play();
        }
    }
}
