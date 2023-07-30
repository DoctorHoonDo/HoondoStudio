using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove8 : MonoBehaviour
{
    public float ori_speed;
    public float Camera_Size;
    public bool isChatting = false;
    public GameObject Camera;
    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public Sprite Sprite5;
    public Sprite Sprite6;
    public Sprite Sprite7;
    public Sprite Sprite8;
    public Sprite Sprite9;
    public Sprite Sprite10;
    public Sprite Sprite11;
    public Sprite Sprite12;
    float ccd_speed;
    bool isWalking = false;
    int walkPrc = 0;
    int lastDirect = 0;
    SpriteRenderer SR;

    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        Camera.GetComponent<Camera>().orthographicSize = Camera_Size;

    }

    IEnumerator WalkLeft()
    {
        lastDirect = 1;
        if (!isWalking && walkPrc == 0)
        {
            SR.sprite = Sprite4;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 1;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 1)
        {
            SR.sprite = Sprite5;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 2;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 2)
        {
            SR.sprite = Sprite6;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 3;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 3)
        {
            SR.sprite = Sprite5;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 0;
            isWalking = false;
        }
    }
    IEnumerator WalkUp()
    {
        lastDirect = 2;
        if (!isWalking && walkPrc == 0)
        {
            SR.sprite = Sprite7;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 1;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 1)
        {
            SR.sprite = Sprite8;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 2;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 2)
        {
            SR.sprite = Sprite9;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 3;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 3)
        {
            SR.sprite = Sprite8;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 0;
            isWalking = false;
        }
    }
    IEnumerator WalkDown()
    {
        lastDirect = 0;
        if (!isWalking && walkPrc == 0)
        {
            SR.sprite = Sprite1;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 1;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 1)
        {
            SR.sprite = Sprite2;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 2;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 2)
        {
            SR.sprite = Sprite3;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 3;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 3)
        {
            SR.sprite = Sprite2;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 0;
            isWalking = false;
        }
    }
    IEnumerator WalkRight()
    {
        lastDirect = 3;
        if (!isWalking && walkPrc == 0)
        {
            SR.sprite = Sprite10;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 1;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 1)
        {
            SR.sprite = Sprite11;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 2;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 2)
        {
            SR.sprite = Sprite12;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 3;
            isWalking = false;
        }
        else if (!isWalking && walkPrc == 3)
        {
            SR.sprite = Sprite11;
            isWalking = true;
            yield return new WaitForSeconds(0.23f);
            walkPrc = 0;
            isWalking = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!isChatting)
        {
            ccd_speed = ori_speed / 20;
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                ccd_speed *= 0.72f;
                transform.position -= new Vector3(ccd_speed * Time.deltaTime, 0);
                transform.position += new Vector3(0, ccd_speed * Time.deltaTime);
                StartCoroutine(WalkUp());
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                ccd_speed *= 0.72f;
                transform.position += new Vector3(ccd_speed * Time.deltaTime, 0);
                transform.position += new Vector3(0, ccd_speed * Time.deltaTime);
                StartCoroutine(WalkUp());
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
            {
                ccd_speed *= 0.72f;
                transform.position -= new Vector3(ccd_speed * Time.deltaTime, 0);
                transform.position -= new Vector3(0, ccd_speed * Time.deltaTime);
                StartCoroutine(WalkDown());
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
            {
                ccd_speed *= 0.72f;
                transform.position += new Vector3(ccd_speed * Time.deltaTime, 0);
                transform.position -= new Vector3(0, ccd_speed * Time.deltaTime);
                StartCoroutine(WalkDown());
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(ccd_speed * Time.deltaTime, 0);
                StartCoroutine(WalkLeft());
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0, ccd_speed * Time.deltaTime);
                StartCoroutine(WalkDown());
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(ccd_speed * Time.deltaTime, 0);
                StartCoroutine(WalkRight());
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, ccd_speed * Time.deltaTime);
                StartCoroutine(WalkUp());
            }
            else if (lastDirect == 0)
            {
                SR.sprite = Sprite2;

            }
            else if (lastDirect == 1)
            {
                SR.sprite = Sprite5;
            }
            else if (lastDirect == 2)
            {
                SR.sprite = Sprite8;
            }
            else if (lastDirect == 3)
            {
                SR.sprite = Sprite11;
            }
        }
        Camera.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 3.08f);
    }
}
