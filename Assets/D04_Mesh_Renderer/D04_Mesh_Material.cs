using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_Mesh_Material : MonoBehaviour
{
    MeshFilter ThisMeshFilter; //Cube 게임 오브젝트의 MeshFilter를 할당할 변수
    public GameObject Sphere, Capsule; //Sphere와 Capsule 게임 오브젝트를 할당할 변수 

    // Start is called before the first frame update
    void Start()
    {
        ThisMeshFilter = GetComponent<MeshFilter>(); //Cube의 MeshFilter 컴포넌트를 ThisMeshFilter에 할당 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 좌클릭
        {
            ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh; //Sphere의 mesh를 Cube의 mesh에 할당
        }
        if (Input.GetMouseButtonDown(1))
        {
            ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh;
        }
    }
}
