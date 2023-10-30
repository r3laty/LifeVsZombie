using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSoundsSetting : MonoBehaviour
{
    [SerializeField] private AudioClip mainMusic;
    void Start()
    {
        AudioSource audioSource = FindObjectOfType<AudioSource>();
        if (audioSource != null)
        {
            audioSource.clip = mainMusic;
            audioSource.Play();
        }
    }
}
