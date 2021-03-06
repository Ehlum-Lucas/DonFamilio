using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, 16)];
    }

    void Update()
    {
        if (!audioSource.isPlaying || Input.GetKey(KeyCode.Space))
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }
}
