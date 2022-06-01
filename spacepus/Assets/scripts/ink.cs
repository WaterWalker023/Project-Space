using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ink : MonoBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
