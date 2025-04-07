using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class HW02_Scene01Controller : MonoBehaviour
{
    public GameObject Lamp;
    public GameObject Flashlight;
    public MeshRenderer lampRenderer;
    public Material lampOnMaterial;
    public Material lampOffMaterial;
    public AudioSource Audio;
    public VideoPlayer Video;

    public void OnClick_LoadScene(Object SceneObject)
    {
        print("Clicked!");
        PlayerPrefs.SetInt("AudioPlaying", Audio.isPlaying ? 1 : 0);
        PlayerPrefs.SetInt("VideoPlaying", Video.isPlaying ? 1 : 0);
        PlayerPrefs.SetInt("FlashlightState", Flashlight.activeSelf ? 1 : 0);

        if (lampRenderer.material == lampOnMaterial)
        {
            PlayerPrefs.SetInt("LampState", 1);
        }
        else
        {
            PlayerPrefs.SetInt("LampState", 0);
        }

        PlayerPrefs.Save();

        SceneManager.LoadScene(SceneObject.name);
    }
}