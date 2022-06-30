using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class bosss : MonoBehaviour
{
    public AudioClip hitsound;
    private Vector3 magnitude = new Vector3(0, 0.03f, 0);
    public bool shake;
    public int shaketimes;
    int framedelay;
    float lasttime;
    float meteortime = 5;
    public GameObject bossink;
    public GameObject meteor;
    public GameObject bossbar;
    public GameObject bossdeath;
    float Posx;
    float Posy;
    public int hp;
    bool inattack;
    int meteorchance;
    public Sprite nohit;
    public Sprite canhit;
    public bool hit;
    private RandomOcto _RandomOcto;
    public AudioClip deathsound;

    // Start is called before the first frame update
    void Start()
    {
        lasttime = 0;
        Instantiate(bossbar, GameObject.Find("Canvas").transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (shaketimes <= 4)
        {
            if (framedelay == 4)
            {
                framedelay = 0;
                if (shake)
                {
                    gameObject.transform.position += magnitude;
                    shake = false;
                }
                else
                {
                    gameObject.transform.position -= magnitude;
                    shake = true;
                    shaketimes++;

                }

            }
            else
            {
                framedelay++;
            }
        }

        lasttime += Time.deltaTime;




        Posx = transform.position.x;
        Posy = transform.position.y;
        if (lasttime > 2 && hp != 0)
        {
            Instantiate(bossink, new Vector3(Posx, Posy, -5), Quaternion.identity);
            lasttime = 0;
        }
        meteortime += Time.deltaTime;
        if (meteortime > 10 && hp != 0)
        {
            meteorchance = Random.Range(2, 4);
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
                AudioSource.PlayClipAtPoint(hitsound, new Vector3(0, 0, -10));
                hp = hp - 1;
                shaketimes = 0;
                hit = false;
                if (hp == 0)
                {
                    AudioSource.PlayClipAtPoint(deathsound, new Vector3(0, 0, -10));
                    Instantiate(bossdeath, new Vector3(Posx-1, Posy, -5), Quaternion.identity);
                    Destroy(gameObject);

                }
            }
            
        }
    }
}
