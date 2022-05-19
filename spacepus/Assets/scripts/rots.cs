using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rots : MonoBehaviour
{
    float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        float start = Random.Range(-5.0f, 5.0f);
        transform.position = new Vector3(14, start, -5);
    }

    // Update is called once per frame
    void Update()
    {
        float update = Random.Range(3f, -3f);
        transform.position += new Vector3(-speed, update, 0) * Time.deltaTime;
        if (transform.position.x < -15)
        {

            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "bullet(Clone)")
        {
            Destroy(gameObject);
        }
        if (collision.collider.name == "player")
        {
            Destroy(gameObject);
        }
        if (collision.collider.name == "SAnicBoom(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
