using UnityEngine;
using UnityEngine.Video;

public class HW02_Scene02Controller : MonoBehaviour
{
    public GameObject Lamp;
    public MeshRenderer lampRenderer;
    public Material lampOnMaterial;
    public Material lampOffMaterial;
    public AudioSource Audio;
    public VideoPlayer Video;
    public GameObject Flashlight;

    void Start()
    {
        if (PlayerPrefs.GetInt("AudioPlaying", 0) == 1)
        {
            Audio.Play();
        }
        else
        {
            Audio.Pause();
        }

        if (PlayerPrefs.GetInt("VideoPlaying", 0) == 1)
        {
            Video.Play();
        }
        else
        {
            Video.Pause();
        }

        if (PlayerPrefs.GetInt("LampState", 0) == 1)
        {
            lampRenderer.material = lampOnMaterial; 
        }
        else
        {
            lampRenderer.material = lampOffMaterial; 
        }

        if (PlayerPrefs.GetInt("FlashlightState", 0) == 1)
        {
            Flashlight.SetActive(true);
        }
        else
        {
            Flashlight.SetActive(false);
        }
    }
}
