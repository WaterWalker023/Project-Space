using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bosss : MonoBehaviour
{
    float lasttime;
    float meteortime = 5;
    public GameObject bossink;
    public GameObject meteor;
    float Posx;
    float Posy;
    int attacktype;
    public int hp;
    bool inattack;
    int meteorchance;
    public Sprite nohit;
    public Sprite canhit;
    public bool hit;
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
        meteortime += Time.deltaTime;
        if (meteortime > 10)
        {
            meteorchance = Random.Range(2, 4);
            Debug.Log(meteorchance);
            if (meteorchance == 2)
            {
                Instantiate(meteor, new Vector3(Posx, -6, -5), Quaternion.identity);
            }
            else
            {
                Instantiate(meteor, new Vector3(Posx, 6, -5), Quaternion.identity);
            }
            
            meteortime = 0;
        }
        if (meteortime == 0)
        {
            //gameObject.GetComponent<Image>().sprite = canhit;
            //GetComponentInChildren<Image>().sprite = canhit;
            hit = true;
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "SAnicBoom(Clone)")
        {
            if (!inattack && hit)
            {
                hp = hp - 1;
                hit = false;
            }
            
        }
    }
}
