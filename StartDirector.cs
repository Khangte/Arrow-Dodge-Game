using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartDirector : MonoBehaviour
{
    // 업데이트마다 호출되는 함수
    void Update()
    {
        // 엔터를 클릭하면 게임 화면으로 전환
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // GameScene으로 씬 전환
            SceneManager.LoadScene("GameScene");
        }

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
        // Unity 에디터에서 실행 중인 경우 에디터 종료
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
        // 웹 플레이어에서 실행 중인 경우 웹페이지 열기
        Application.OpenURL("http://google.com");
# else
        // 그 외의 경우 애플리케이션 종료
        Application.Quit();
#endif
    }
}
