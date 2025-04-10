using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Animation_Vehicle_Controller : MonoBehaviour
{
    public Animator animator;
    public GameObject vehicle;

    private bool isGoingToRoom2 = true;
    private bool isPaused = false;

    Vector3 room1 = new Vector3(0, 0, -30);
    Vector3 room2 = new Vector3(0, 0, 30);

    public void StartMoving()
    {
        print(animator);
        if (!isPaused)
        {
            if (isGoingToRoom2)
            {
                animator.SetInteger("status", 1);
            }
            else
            {
                print("오게되");
                animator.SetInteger("status", 2);
            }
        }
        
        animator.speed = 1f;
        isPaused = false;
    }

    public void StopMoving()
    {
        int currentStatus = animator.GetInteger("status");
        Vector3 pos = vehicle.transform.position;
        print(currentStatus);
        print(pos);

        if (pos == room1 || pos == room2)
        {
            animator.SetInteger("status", 0);
            currentStatus = 0;
            print("도착");
            if (pos == room2) isGoingToRoom2 = false;
            else if (pos == room1) isGoingToRoom2 = true;
        }
        else if (currentStatus == 1 || currentStatus == 2)
        {
            print("정지");
            isPaused = true;
            animator.speed = 0f;
        }
    }
}
