using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAnicBoom : MonoBehaviour
{
    GameObject player;
    float speed = 7f;
    float Grote = 0.15f;
    void Start()
    {
        player = GameObject.Find("player");
        transform.position = player.transform.position;
        Destroy(gameObject, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        transform.localScale = new Vector3(Grote, Grote, Grote);
        Grote += Grote * Time.deltaTime;
    }
    
}
