using JetBrains.Annotations;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        /// Input system (Old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> wasd or 화살표키보드
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽

        //if(Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}

        float h = Input.GetAxis("Horizontal");  // x축 값을 가져옴.
        float v = Input.GetAxis("Vertical");    // z축 값을 가져옴.

        Vector3 dir = new Vector3(h, 0, v);     // 좌표값을 dir 변수에 초기화
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
