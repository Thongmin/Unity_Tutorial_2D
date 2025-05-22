using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destroyObj;

    public Vector3 pos;     //위치값
    public Quaternion rot;  //회전값

    void Start()
    {
        CreateAmongus();

        //Destroy(destroyObj, 4f);    //매개변수를 파괴하는 함수
        
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab, pos, rot);    // GameObject를 생성하는 함수
        obj.name = "어몽어스 캐릭터";

        Transform objTF = obj.transform;
        int count = objTF.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {obj.transform.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {obj.transform.GetChild(count - 1).name}");
    }
}
