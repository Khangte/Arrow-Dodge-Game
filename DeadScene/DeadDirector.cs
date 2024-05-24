DeadDirector
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene 사용

public class DeadDirector : MonoBehaviour
{
    void Update()
    {
        // 엔터를 클릭하면 게임 화면으로 전환한다.
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
