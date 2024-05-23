using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    // 게이지를 표시할 UI 오브젝트
    GameObject hpGauge;

    void Start()
    {
        // 시작할 때 hpGauge 오브젝트를 찾아서 할당
        this.hpGauge = GameObject.Find("hpGauge");
    }

    void Update()
    {
        // esc 키를 누르면 게임 종료
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    // 게임 종료 함수
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Unity 에디터에서 실행 중인 경우 에디터 종료
#elif UNITY_WEBPLAYER
        Application.OpenURL("http://google.com"); // 웹 플레이어에서 실행 중인 경우 웹페이지 열기
# else
        Application.Quit(); // 그 외의 경우 애플리케이션 종료
#endif
    }

    // 게이지 감소 함수
    public void DecreaseHp()
    {
        // 게이지를 감소시킴
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;

        // 게이지가 0이 되면
        if (this.hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            // DeadScene으로 화면 전환
            SceneManager.LoadScene("DeadScene");
        }
    }

    // 게이지 증가 함수
    public void IncreaseHp()
    {
        // 게이지를 증가시킴
        if (this.hpGauge.GetComponent<Image>().fillAmount < 1f)
        {
            this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
        }
    }

    // 게이지 절반 감소 함수
    public void DecreaseHp_Half()
    {
        // 피게이지의 절반을 감소시킴
        if (this.hpGauge.GetComponent<Image>().fillAmount > 0.5f)
        {
            this.hpGauge.GetComponent<Image>().fillAmount -= 0.5f;
        }
        else    // 피게이지가 절반 이하이면
        {
            // DeadScene으로 신변경 
            SceneManager.LoadScene("DeadScene");
        }
    }
}
