using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    GameObject player; // 플레이어 오브젝트에 대한 참조

    void Start()
    {
        // 시작할 때 플레이어 오브젝트를 찾아서 할당
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        // 프레임마다 등속으로 아래로 낙하시킴
        transform.Translate(0, -0.07f, 0);

        // 화면 밖으로 나오면 오브젝트를 소멸시킴
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position;                // 폭탄 중심 좌표
        Vector2 p2 = this.player.transform.position;    // 플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;                        // 거리 계산
        float r1 = 0.5f;                                // 폭탄 반경
        float r2 = 1.0f;                                // 플레이어 반경

        if (d < r1 + r2)
        {
            // 감독 스크립트에 플레이어와 폭탄이 충돌했다고 전달
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp_Half();

            // 충돌한 경우 폭탄을 삭제
            Destroy(gameObject);
        }
    }
}
