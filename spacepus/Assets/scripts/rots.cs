using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rots : MonoBehaviour
{
    public GameObject deathpartical;
    public GameObject Health;
    public GameObject energy;
    public GameObject powerup;
    public GameObject shield;
    public GameObject ink;
    public float speed = 2f;
    private walking _walking;
    private CameraShake _CameraShake;
    private RandomOcto _RandomOcto;
    public float time;
    int delay = 2;
    public int type;
    float Posx;
    float Posy;
    public bool schiet;
    public AudioClip death;
    public AudioClip wallhit;
    // Start is called before the first frame update
    // 
    void Start()
    {
        _walking = GameObject.Find("player").GetComponent<walking>();
        _RandomOcto = GameObject.Find("randomocto").GetComponent<RandomOcto>();
        _CameraShake = GameObject.Find("Main Camera").GetComponent<CameraShake>();
        float start = Random.Range(-5.0f, 5.0f);
        transform.position = new Vector3(14, start, -5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        if (transform.position.x < -15)
        {
            AudioSource.PlayClipAtPoint(wallhit, new Vector3(0, 0, -10));
            _walking.hp = _walking.hp - 1;
            _CameraShake.shaketimes = 0;
            Destroy(gameObject);
            
        }
        if (schiet)
        {
            time += Time.deltaTime;
            if (time > delay)
            {
                Posx = transform.position.x;
                Posy = transform.position.y;
                time = 0;
                Instantiate(ink, new Vector3(Posx, Posy, -5), Quaternion.identity);
            }
        }
        if (!_RandomOcto.enemy)
        {

            Posx = transform.position.x;
            Posy = transform.position.y;
            AudioSource.PlayClipAtPoint(death, new Vector3(0, 0, -10));
            Instantiate(deathpartical, new Vector3(Posx, Posy, -5), Quaternion.identity);
            Destroy(gameObject);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "bullet(Clone)" || collision.collider.name == "SAnicBoom(Clone)")
        {
            Posx = transform.position.x;
            Posy = transform.position.y;
            int chance = Random.Range(1, 40);
            if (chance == 1)
            {
                Instantiate(powerup);
            }
            if (chance == 2)
            {
                Instantiate(energy);
            }
            if (chance == 3)
            {
                Instantiate(Health);
            }
            if (chance >= 4 && chance <= 8)
            {
                if (_RandomOcto.noboss)
                {
                    Instantiate(shield);
                }
                
            }
            AudioSource.PlayClipAtPoint(death, new Vector3(0, 0, -10));
            Instantiate(deathpartical, new Vector3(Posx, Posy, -5), Quaternion.identity);
            Destroy(gameObject);
        }

        if (collision.collider.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
