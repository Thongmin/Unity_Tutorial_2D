using UnityEditor.SearchService;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;      // GameObject type의 변수 생성
    public Mesh msh;           // Mesh Type의 변수 생성
    public Material mat;   // Material Type의 변수 생성
    //private Transform objTF;    // Transform type의 변수 생성
    //public string changeName;

    void Start()
    {
        //obj = GameObject.Find("Main Camera"); // 어떠한 GameObject를 찾기 위한 함수 Find(string)
        //obj = GameObject.FindGameObjectWithTag("Player");
        //objTF = GameObject.FindGameObjectWithTag("Player").transform;
        //Debug.Log($"GameObject Name : {obj.name} / GameObject Tag : {obj.tag}");
        //Debug.Log($"Position : {obj.transform.position} / Rotation : {obj.transform.rotation} / LocalScale : {obj.transform.localScale}");
        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");
        //obj.GetComponent<MeshRenderer>().enabled = false; //<> 안에 있는 Component의 활성화 할 지 안 할지 정하는 코드
        //obj.SetActive(false); //obj에 있는 GameObject의 활성 상태 변경하는 함수
        //objTF.gameObject.SetActive(false);  // objTF는 Transform이고 SetActive()는 GameObject 함수이기 때문에 앞에 gameObject가 붙음.
                                              // = .GetComponent<Transform>.enabled = false
        //obj.name = changeName; // Object의 이름을 바꿈

        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); // Unity에서 기본적으로 지원하는 3d 도형 (Primitive)를 써서 Cube를 생성하는 함수

        CreateCube();
        CreateCube("Hello World");
    }

    public void CreateCube(string name = "Cube")
    {
        obj = new GameObject(name);   //Cube라는 이름의 GameObject 생성

        obj.AddComponent<MeshFilter>(); //GameObject에 Component 추가하는 함수
        obj.GetComponent<MeshFilter>().mesh = msh;          //MeshFilter Component에서 mesh 변수의 값을 받는 코드

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;    //MeshRenderer Component에서 material 변수의 값을 받는 코드

        obj.AddComponent<BoxCollider>();
    }
}
