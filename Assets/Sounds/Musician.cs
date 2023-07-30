using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Musician : MonoBehaviour
{
    public bool MusicDown;
    public float time;
    AudioSource music;
    IEnumerator Bye()
    {
        yield return new WaitForSeconds(time / 5);
        Destroy(this.gameObject);
    }
    void Start()
    {
        music = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if (music.time >= time && !MusicDown)
        {
            Instantiate(this.gameObject);
            MusicDown = true;
            StartCoroutine(Bye());
        }
    }
}
