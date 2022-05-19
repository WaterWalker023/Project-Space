using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{

    public float en = 0;
    public int hp = 0;
    public GameObject rots;
    public GameObject bullet;
    public GameObject SAnicBoom;

    int maxen = 100;
    float enpersec = 1f;
    float encound = 0;
    public float moveSpeed = 5f;
    int wallleft = 9;
    int wallright = -9;
    int wallup = 5;
    int walldown = -5;

    
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D) && (transform.position.x < wallleft))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.A) && (transform.position.x > wallright))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.W) && (transform.position.y < wallup))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.S) && (transform.position.y > walldown))
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet);
        }

        if (en != maxen)
        {
            encound += Time.deltaTime;
            if (encound > enpersec)
            {
                encound = encound - enpersec;
                en++;
            }
        }


        if (Input.GetKeyDown(KeyCode.E) && en >= 20)
        {
            Instantiate(SAnicBoom);
            en = en - 20;
        }


        if (hp == 0)
        {
            Destroy(gameObject);
        }


        
        if (Input.GetKey(KeyCode.O))
        {
            Instantiate(rots);
        }


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "rots(Clone)")
        {
            hp = hp - 1;
        }
        if (collision.collider.name == "speedup")
        {
            moveSpeed = moveSpeed + moveSpeed;
        }

    }
}
