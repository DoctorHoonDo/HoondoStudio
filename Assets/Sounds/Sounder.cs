using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounder : MonoBehaviour
{
    public float time;
    IEnumerator Exit()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
    void Start()

    {
        StartCoroutine(Exit());
    }
}
