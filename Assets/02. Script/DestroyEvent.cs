using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 0f;

    void Start()
    {
        Destroy(this.gameObject, destroyTime);   //자기 자신을 3초뒤에 파괴

        
    }

    private void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다.");
    }
}
