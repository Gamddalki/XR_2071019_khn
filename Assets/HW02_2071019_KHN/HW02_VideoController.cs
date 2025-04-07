using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class HW02_VideoController : MonoBehaviour
{
    public VideoPlayer Video;
    void Start()
    {
        Video.Play();
        Video.isLooping = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (Video.isPlaying)
            {
                //Video.Stop();
                Video.Pause();
            }
            else
            {
                Video.Play();
            }
        }
    }
}
