using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSFXPlayer : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayRandomSound();
    }
    void PlayRandomSound()
    {
        if (audioClips.Length > 0)
        {
            int randomIndex = Random.Range(0, audioClips.Length);
            audioSource.clip = audioClips[randomIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No audio clips assigned to the array!");
        }
    }
}
