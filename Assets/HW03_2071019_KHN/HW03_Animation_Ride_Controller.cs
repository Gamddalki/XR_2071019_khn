using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HW03_Animation_Ride_Controller : MonoBehaviour
{
    public HW03_Animation_Vehicle_Controller vehicleController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Vehicle")
        {
            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;

            vehicleController.StartMoving();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle")
        {
            transform.SetParent(null);

            vehicleController.StopMoving();
        }
    }
}