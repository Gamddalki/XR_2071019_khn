using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * 180 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
    }
}
