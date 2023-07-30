using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog1 : Dialog
{
    IEnumerator Chat()
    {
        ChatStart();
        ImageChange(0, "001/Disappointed0");
        Talker(0, 1);
        NameChange("베런 세프톤");
        StartCoroutine(Talk(0, "일이랑은 관련없는 심부름 밖에 안 시키고..", 0.12f));
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
        ImageChange(0, "001/Problem0");
        StartCoroutine(Talk(0, "연구는 제대로 하고 있는건지..", 0.12f));
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
        ImageChange(0, "001/Normal0");
        StartCoroutine(Talk(0, "갔다오기나 하자.", 0.12f));
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
        ChatExit();
    }
    void Start()
    {
        StartCoroutine(Chat());
    }
    
}
