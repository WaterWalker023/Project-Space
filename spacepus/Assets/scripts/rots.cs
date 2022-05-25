using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rots : MonoBehaviour
{
    public GameObject energy;
    public GameObject powerup;
    float speed = 2f;
    
    private walking _walking;
    // Start is called before the first frame update

    void Start()
    {
        _walking = GameObject.Find("player").GetComponent<walking>();
        float start = Random.Range(-5.0f, 5.0f);
        transform.position = new Vector3(14, start, -5);
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        if (transform.position.x < -15)
        {

            _walking.hp = _walking.hp - 1;
            Destroy(gameObject);
            
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "bullet(Clone)" || collision.collider.name == "SAnicBoom(Clone)")
        {
            int chance = Random.Range(1, 10);
            Debug.Log(chance);
            if (chance == 1)
            {
                Instantiate(powerup);
            }
            Debug.Log(chance);
            if (chance == 2)
            {
                Instantiate(energy);
            }
            Destroy(gameObject);
        }
        if (collision.collider.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
