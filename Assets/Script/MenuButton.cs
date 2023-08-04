using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuButton : MonoBehaviour
{
    public string movescene;
    public Image Black;
    public IEnumerator MoveSceneNumeral(string A)
    {
        while (Black.color.a < 1)
        {
            Black.color = new Vector4(0, 0, 0, Black.color.a+0.01f);
            if(Black.color.a > 1)
            {
                break;
            }
            yield return new WaitForSeconds(0.01f);
        }
        SceneManager.LoadScene(A);
    }
    public void Movescene()
    {
        StartCoroutine(MoveSceneNumeral(movescene));
    }
}
