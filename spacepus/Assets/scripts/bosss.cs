using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bosss : MonoBehaviour
{
    float lasttime;
    public GameObject bossink;
    float Posx;
    float Posy;
    int attacktype;
    public int hp;
    bool inattack;
    // Start is called before the first frame update
    void Start()
    {
        lasttime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        lasttime += Time.deltaTime;
        if (hp == 0)
        {
            SceneManager.LoadScene("end");
        }
        Posx = transform.position.x;
        Posy = transform.position.y;
        if (lasttime > 2)
        {
            Instantiate(bossink, new Vector3(Posx, Posy, -5), Quaternion.identity);
            lasttime = 0;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "SAnicBoom(Clone)")
        {
            if (!inattack)
            {
                hp = hp - 1;
            }
            
        }
    }
}
