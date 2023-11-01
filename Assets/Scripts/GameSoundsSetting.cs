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
        //else
        //{
        //    AudioSource newAudioSource = gameObject.AddComponent<AudioSource>();
        //    newAudioSource.clip = mainMusic;
        //    newAudioSource.Play();
        //    newAudioSource.volume = 0.3f;
        //}
    }
}
