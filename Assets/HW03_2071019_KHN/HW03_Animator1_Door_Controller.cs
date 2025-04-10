using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Animator1_Door_Controller : MonoBehaviour
{
    public Animator Animator;
    public Transform doorTransform; // 문의 앞 방향 기준
    public Transform player; // FPSController

    private void OnTriggerEnter(Collider other)
    {
        Vector3 toPlayer = (player.position - doorTransform.position).normalized;
        float dot = Vector3.Dot(doorTransform.forward, toPlayer);

        if (dot > 0)
        {
            Animator.SetInteger("status", 1);
        }
        else
        {
            Animator.SetInteger("status", 2);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Vector3 toPlayer = (player.position - doorTransform.position).normalized;
        float dot = Vector3.Dot(doorTransform.forward, toPlayer);

        if (dot < 0)
        {
            Animator.SetInteger("status", 3);
        }
        else
        {
            Animator.SetInteger("status", 4);
        }
    }
}
