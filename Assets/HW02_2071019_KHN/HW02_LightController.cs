using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light lampLight;
    public MeshRenderer lampRenderer;
    public Material lampOnMaterial;
    public Material lampOffMaterial;

    private int state = 0;

    private void Start()
    {
        state = 0;
        lampLight.enabled = false;
        lampRenderer.material = lampOffMaterial;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (state == 0)
            {
                lampRenderer.material = lampOnMaterial;
                lampLight.enabled = true;
                state = 1;
                print("Lamp On");
            }
            else
            {
                lampRenderer.material = lampOffMaterial;
                lampLight.enabled = false;
                state = 0;
                print("Lamp Off");
            }
        }
    }
}
