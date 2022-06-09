using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossink : MonoBehaviour
{

    private Vector3 directie;
    public Vector3 player;
    GameObject boss;
    float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform.position;
        directie = (player - transform.position).normalized * Time.deltaTime;
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (transform.position.x, transform.position.y, -5);
        transform.position += directie * speed;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "player" || collision.collider.name == "SAnicBoom(Clone)")
        {
            Destroy(gameObject);
        }
    }
}

