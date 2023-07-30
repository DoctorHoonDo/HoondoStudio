using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image image;
    public float time;
    IEnumerator AAA()
    {
        float i = 1;
        while (i >= 0)
        {
            i -= 0.01f;
            image.color = new Vector4(0, 0, 0, i);
            yield return new WaitForSeconds(time);
        }
    }
    void Start()
    {
        StartCoroutine(AAA());
    }
    
}
