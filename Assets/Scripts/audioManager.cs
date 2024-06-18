using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [Header("-------------- Audio Source --------------")]
    [SerializeField] public AudioSource musicSource;
    [SerializeField] public AudioSource SFXSource;
    [Header("-------------- Audio Clip --------------")]
    public AudioClip background;
    public AudioClip lose;
    public AudioClip win;
    public AudioClip push;
    void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
        musicSource.loop = false;
        StartCoroutine(ReplayMusicAfterCompletion());
    }
    private void Awake()
    {
  
    }
    IEnumerator ReplayMusicAfterCompletion()
    {
        while (true)
        {
            yield return new WaitForSeconds(musicSource.clip.length);
            ReplayMusic();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
    void ReplayMusic()
    {
        musicSource.Play();
    }
}
