//유니티 C# 스크립트 작성에 필요한 네임스페이스
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_Mesh_Renderer : MonoBehaviour //유니티 C# 클래스는 MonoBehavior를 상속함
                                               //기본적으로는 다른 스크립트가 참조할 수 있도록 접근지정자가 public 
{
    // 유니티가 Play 모드로 전환될 때 초기 1회 실행되는 함수
    void Start()
    {
        print("Hello World!");
        Debug.Log(gameObject.name);
    }

    // 유니티 Play 모드가 종료될 때까지 반복해서 실행되는 함수
    void Update()
    {
        
    }
}
