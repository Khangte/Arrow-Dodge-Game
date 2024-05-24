using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealGenerator : MonoBehaviour
{
    public GameObject healPrefab; // 생성할 힐 프리팹
    float span = 3.3f;            // 힐 생성 주기 (3.3초마다 생성)
    float delta = 0;              // 경과 시간을 측정하기 위한 변수

    void Update()
    {
        // 경과 시간을 누적
        this.delta += Time.deltaTime;
        
        // 주기마다 힐 생성
        if (this.delta > this.span)
        {
            // 경과 시간 초기화
            this.delta = 0;

            // 힐 프리팹을 복제하여 씬에 생성
            GameObject go = Instantiate(healPrefab) as GameObject;

            // 힐을 불규칙하게 생성하기 위해 x좌표를 무작위로 설정
            int px = Random.Range(-6, 7);   // x좌표 -6, 6 사이에 불규칙하게 위치
            go.transform.position = new Vector3(px, 7, 0); // 위에서 아래로 힐이 낙하
        }
    }
}
