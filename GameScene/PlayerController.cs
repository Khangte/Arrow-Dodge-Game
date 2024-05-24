using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        // 우측 방향키 누르는동안 우측 이동
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.05f, 0, 0);
        }

        // 좌측 방향키 누르는 동안 좌측 이동
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.05f, 0, 0);
        }

        //화면 밖으로 못나가게 한다.
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0.05f) pos.x = 0.05f; // 화면 좌측 끝에 닿으면 위치 조정
        if (pos.x > 0.95f) pos.x = 0.95f; // 화면 우측 끝에 닿으면 위치 조정
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
