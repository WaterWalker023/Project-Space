using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    GameObject player;
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        transform.position = player.transform.position;
        Destroy(gameObject, 1.01f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "rots(Clone)" || collision.collider.name == "snelrots(Clone)" || collision.collider.name == "schietrots(Clone)")
        {
            Destroy(gameObject,0.5f);
        }
    }
}