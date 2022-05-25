using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        float start = Random.Range(-8.0f, 8.0f);
        transform.position = new Vector3(start, 6, -5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
        if (transform.position.y < -7)
        {

            Destroy(gameObject);

        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
