using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW02_AudioController : MonoBehaviour
{
    public AudioSource Audio;
    void Start()
    {
        Audio.loop = true;
        Audio.Play();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (Audio.isPlaying)
            {
                Audio.Pause();
            }
            else
            {
                Audio.Play();
            }   
        }
    }
}
