using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW02_FlashlightController : MonoBehaviour
{
    public int state;
    public GameObject Lamp;
    private void Start()
    {
        state = 0;
        Lamp.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (state == 0)
            {
                Lamp.SetActive(true);
                state = 1;
            }
            else if (state == 1)
            {
                Lamp.SetActive(false);
                state = 0;
            }
        }
    }
}
