using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource birdDescription;
    void Start()
    {
        birdDescription = GetComponent<AudioSource>();
    }

    public void PlayAudioBird()
    {
        birdDescription.Play();
    }
}
