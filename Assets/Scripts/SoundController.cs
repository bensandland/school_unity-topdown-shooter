using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static AudioClip shootSound;
    static AudioSource source;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        shootSound = Resources.Load<AudioClip>("light-gun");
        source = GetComponent<AudioSource>();
    }

    public static void PlaySound()
    {
        source.Play();
    }
}
