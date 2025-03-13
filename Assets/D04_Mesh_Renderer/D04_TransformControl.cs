using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_TransformControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) //위쪽 방향키 클릭 시 (0,1,0)으로 이동
        {
            transform.Translate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //왼쪽 방향키 클릭 시 y축을 회전축으로 하여 시계 방향으로 회전
        {
            transform.Rotate(0, 1, 0);
        }
    }
}
