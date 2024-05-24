using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;    // TextMeshPro 사용

public class StartText : MonoBehaviour
{
    // 텍스트 오브젝트에 대한 참조
    public TextMeshProUGUI text;

    // 게임 오브젝트가 활성화될 때 호출되는 함수
    void Start()
    {
        // 텍스트 페이드 아웃 코루틴 시작
        StartCoroutine(FadeOutText());
        
        // TextMeshProUGUI 컴포넌트에 대한 참조 가져오기
        text = GetComponent<TextMeshProUGUI>();
    }

    // 텍스트를 서서히 페이드 아웃시키는 코루틴
    public IEnumerator FadeOutText()
    {
        // 텍스트의 알파 값을 최대로 설정 (투명하지 않음)
        text.color = new Color(text.color.r, text.color.g, text.color.b, 1);

        // 텍스트의 알파 값이 0보다 큰 동안 반복
        while (text.color.a > 0.0f)
        {
            // 텍스트의 알파 값을 서서히 감소시킴 (페이드 아웃)
            text.color = new Color(text.color.r, text.color.g, text.color.b, 
                text.color.a - (Time.deltaTime / 1.0f));    // 1초동안 페이드아웃

            // 다음 프레임까지 대기
            yield return null;
        }
    }
}
