using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class audio : MonoBehaviour
{
    public AudioClip backgroundMusic; 
    private AudioSource bgm;

    private void Start()
    {
        bgm = GetComponent<AudioSource>();
        bgm.clip = backgroundMusic;
        bgm.loop = true;
        bgm.Play();
    }
}
