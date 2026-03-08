using UnityEngine;

public class SpeakerSound : MonoBehaviour
{
    public AudioSource speaker;

    void Start()
    {
        speaker.spatialBlend = 1f; // ทำให้เป็น 3D sound
        speaker.Play();
    }
}