using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_Mesh_Material : MonoBehaviour
{
    MeshFilter ThisMeshFilter; //Cube ���� ������Ʈ�� MeshFilter�� �Ҵ��� ����
    public GameObject Sphere, Capsule; //Sphere�� Capsule ���� ������Ʈ�� �Ҵ��� ���� 

    // Start is called before the first frame update
    void Start()
    {
        ThisMeshFilter = GetComponent<MeshFilter>(); //Cube�� MeshFilter ������Ʈ�� ThisMeshFilter�� �Ҵ� 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���콺 ��Ŭ��
        {
            ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh; //Sphere�� mesh�� Cube�� mesh�� �Ҵ�
        }
        if (Input.GetMouseButtonDown(1))
        {
            ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh;
        }
    }
}
