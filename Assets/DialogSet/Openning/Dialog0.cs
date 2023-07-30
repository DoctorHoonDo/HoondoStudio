using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Dialog0 : Dialog
{
    public Image blackfade;
    public string nextScene;
    IEnumerator Chat()
    {
        ChatStart();
        ImageChange(0, "001/Normal0");
        ImageChange(1, "002/Normal1");
        Talker(0, 0);
        Talker(1, 1);
        NameChange("더슬 디트먼");
        StartCoroutine(Talk(1, "이쪽 중심상가에 브레들리 스콧의 빵집이 있어.", 0.1f));
        while (true)
        {
            PlayerMove.isChatting = true;
            yield return new WaitForSeconds(0.01f * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                Skip = true;
                if (isEnd)
                {
                    Skip = false;
                    isEnd = false;
                    Instantiate(NextSound);
                    break;
                }
            }
        }
        StartCoroutine(Talk(1, "거기서 멜론빵 좀 사와.", 0.1f));
        while (true)
        {
            yield return new WaitForSeconds(0.01f * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                Skip = true;
                if (isEnd)
                {
                    Skip = false;
                    isEnd = false;
                    Instantiate(NextSound);
                    break;
                }
            }
        }
        ImageChange(0, "001/Problem0");
        ImageChange(1, "002/Normal0");
        Talker(0, 1);
        Talker(1, 0);
        NameChange("베런 세프톤");
        StartCoroutine(Talk(0, "브레들리 스콧은 예전에 돌아가셨잖아요..", 0.12f));
        while (true)
        {
            yield return new WaitForSeconds(0.01f * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                Skip = true;
                if (isEnd)
                {
                    Skip = false;
                    isEnd = false;
                    Instantiate(NextSound);
                    break;
                }
            }
        }
        ImageChange(1, "002/Normal1");
        Talker(0, 0);
        Talker(1, 1);
        NameChange("더슬 디트먼");
        StartCoroutine(Talk(1, "아니, 제자가 빵집을 한대!", 0.1f));
        while (true)
        {
            yield return new WaitForSeconds(0.01f * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                Skip = true;
                if (isEnd)
                {
                    Skip = false;
                    isEnd = false;
                    Instantiate(NextSound);
                    break;
                }
            }
        }
        ImageChange(0, "001/Disappointed0");
        ImageChange(1, "002/Normal0");
        Talker(0, 1);
        Talker(1, 0);
        NameChange("베런 세프톤");
        StartCoroutine(Talk(0, "브레들리 브레드는 그 빵 레시피를 모른다구요!", 0.12f));
        while (true)
        {
            yield return new WaitForSeconds(0.01f * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                Skip = true;
                if (isEnd)
                {
                    Skip = false;
                    isEnd = false;
                    Instantiate(NextSound);
                    break;
                }
            }
        }
        ImageChange(1, "002/Angry0");
        Talker(0, 0);
        Talker(1, 1);
        NameChange("더슬 디트먼");
        StartCoroutine(Talk(1, "닥쳐!.. 네 미모정도로 부탁하면 해 줄 수도 있잖아!", 0.1f));
        while (true)
        {
            yield return new WaitForSeconds(0.01f * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                Skip = true;
                if (isEnd)
                {
                    Skip = false;
                    isEnd = false;
                    Instantiate(NextSound);
                    break;
                }
            }
        }
        ImageChange(0, "001/Problem1");
        Talker(0, 1);
        Talker(1, 0);
        NameChange("베런 세프톤");
        StartCoroutine(Talk(0, "미친소리!..", 0.2f));
        while (true)
        {
            yield return new WaitForSeconds(0.01f * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                Skip = true;
                if (isEnd)
                {
                    Skip = false;
                    isEnd = false;
                    Instantiate(NextSound);
                    break;
                }
            }
        }
        ChatExit();
        StartCoroutine(NextScene());
    }
    IEnumerator NextScene()
    {
        float i = 0;
        while (i <= 1.5)
        {
            i += 0.01f;
            blackfade.color = new Vector4(0, 0, 0, i);
            yield return new WaitForSeconds(0.01f);
        }
        SceneManager.LoadScene(nextScene);
    }
    void Start()
    {
        StartCoroutine(Chat());
    }
}
