using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialog : MonoBehaviour
{
    public PlayerMove8 PlayerMove;      
    public Text Name;
    public Text Content;
    public GameObject DialogBubble;
    public GameObject Character0;
    public GameObject Character1;
    public GameObject Voice0;
    public GameObject Voice1;
    public GameObject NextSound;
    public bool Skip = false;
    public bool isEnd = false;
    public IEnumerator Talk(int who, string content, float typingsecond)
    {
        string contents; int A;
        if (who == 0)
        {
            contents = "";
            A = 0;
            while (A < content.Length)
            {
                contents += content[A];
                Content.text = contents;
                if(content[A] != ' ' && !Skip)
                {
                    Instantiate(Voice0);
                    yield return new WaitForSeconds(typingsecond);
                }
                A++;

            }
        }
        else if (who == 1)
        {
            contents = "";
            A = 0;
            while (A < content.Length)
            {
                contents += content[A];
                Content.text = contents;
                if (content[A] != ' ' && !Skip)
                {
                    Instantiate(Voice1);
                    yield return new WaitForSeconds(typingsecond);
                }
                A++;

            }
        }
        isEnd = true;
    }
    public void Talker(int a, int b)
    {
        if (a == 0)
        {
            if (b == 1)
            {
                Character0.GetComponent<Image>().color = new Vector4(1, 1, 1, 1f);
            }
            else
            {
                Character0.GetComponent<Image>().color = new Vector4(1, 1, 1, 0.7f);

            }
        }
        else if (a == 1)
        {
            if (b == 1)
            {
                Character1.GetComponent<Image>().color = new Vector4(1, 1, 1, 1f);
            }
            else
            {
                Character1.GetComponent<Image>().color = new Vector4(1, 1, 1, 0.7f);
            }

        }
    }
    public void NameChange(string A)
    {
        Name.text = A;
    }
    public void ImageChange(int who, string path)
    {
        if(who == 0)
        {
            Character0.GetComponent<Image>().sprite = Resources.Load<Sprite>("Character/Stand/" + path);
        }
        else if(who == 1)
        {
            Character1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Character/Stand/" + path);
        }
    }
    public void ChatStart()
    {
        PlayerMove.isChatting = true;
        DialogBubble.SetActive(true);
    }
    public void ChatExit()
    {
        Character1.GetComponent<Image>().color = new Vector4(1, 1, 1, 0f);
        Character0.GetComponent<Image>().color = new Vector4(1, 1, 1, 0f);
        PlayerMove.isChatting = false;
        DialogBubble.SetActive(false);
    }
}
