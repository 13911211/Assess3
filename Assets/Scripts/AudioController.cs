using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioClip audioClip1;
    public AudioClip audioClip2;

    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();

        // Assign the audio clips to the AudioSource
        audioSource.clip = audioClip1;

        // Play the first audio clip
        audioSource.Play();

        // Wait for the duration of the first clip
        PlaySecondAudioAfterDelay(audioClip1.length);
    }

    void PlaySecondAudioAfterDelay(float delay)
    {
        // Wait for the duration of the first clip
        Invoke("PlaySecondAudio", delay);
    }

    void PlaySecondAudio()
    {
        // Assign the second audio clip
        audioSource.clip = audioClip2;

        // Enable looping for the second audio clip
        audioSource.loop = true;

        // Start playing the second audio clip
        audioSource.Play();
    }
}
