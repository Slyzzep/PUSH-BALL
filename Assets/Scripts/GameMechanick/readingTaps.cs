using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readingTaps : MonoBehaviour
{
    public GameObject objectToCreate;
   // [SerializeField] public ParticleSystem particletap;
    void Start()
    {
        
    }
    void Update()
    {
        // Перевірка наявності доторкання до екрану
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            GameObject newObject = Instantiate(objectToCreate, touchPosition, Quaternion.identity);
            Destroy(newObject, 0.2f);
            //particlesystem
           // ParticleSystem newParticleTap = Instantiate(particletap, touchPosition, Quaternion.identity);
            //destroyparticle
           // float particleDuration = newParticleTap.main.duration;
           // Destroy(newParticleTap.gameObject, 4f);

        }


    }
}

