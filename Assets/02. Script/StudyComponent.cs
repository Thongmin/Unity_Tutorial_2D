using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;       // GameObject type의 변수 생성

    public string changeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera"); // Game Object 인 어떤 것들 찾기 위한 함수 Find(string)

        obj.name = changeName; // Object의 이름을 바꿈
    }
}
