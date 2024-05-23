using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;    // TextMeshPro 사용

public class second : MonoBehaviour
{
    public float runTime_sec;           // 러닝타임(초)을 저장하는 변수
    public TextMeshProUGUI text_Time;   // 텍스트를 표시할 TextMeshProUGUI 컴포넌트

    void Update()
    {
        // 러닝타임 갱신
        runTime_sec += Time.deltaTime;

        // 텍스트 업데이트
        // 러닝타임(초)을 정수로 변환하여 60으로 나눈 나머지를 표시
        text_Time.text = ((int)runTime_sec % 60).ToString();
    }
}
