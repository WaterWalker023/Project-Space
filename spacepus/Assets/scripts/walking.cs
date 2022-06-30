using UnityEngine;
using UnityEngine.SceneManagement;



public class walking : MonoBehaviour
{
    AudioSource audio;
    public bool shield;
    public int en = 0;
    public int hp = 0;
    public GameObject bullet;
    public GameObject SAnicBoom;
    private CameraShake _CameraShake;

    public float speedtime = 0;
    int speed = 0;
    int maxen = 100;
    float enpersec = 1f;
    float encound = 0;
    [SerializeField] private float moveSpeed = 5f;
    int wallleft = 9;
    int wallright = -9;
    int wallup = 5;
    int walldown = -5;
    bool slowdown = false;
    public int gothit = 5;

    
    
    void Awake()
    {
        _CameraShake = GameObject.Find("Main Camera").GetComponent<CameraShake>();
        audio = this.GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D) && (transform.position.x < wallleft))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.A) && (transform.position.x > wallright))
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
        


        if (Input.GetKey(KeyCode.W) && (transform.position.y < wallup))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.S) && (transform.position.y > walldown))
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.Space) && en >= 1)
        {
            Instantiate(bullet);
            en = en - 1;
        }

        if (en !< maxen && slowdown == false)
        {
            encound += Time.deltaTime;
            if (encound > enpersec)
            {
                encound = encound - enpersec;
                en++;
            }
        }
        if (en > 100)
        {
            en = 100;
        }


        if (Input.GetKeyDown(KeyCode.E) && en >= 15)
        {
            Instantiate(SAnicBoom);
            en = en - 15;
        }


        if (hp <= 0)
        {
            Destroy(gameObject);            
            SceneManager.LoadScene("Death");
        }

        if(speed == 1)
        {
            speedtime = speedtime + Time.deltaTime;
            if (speedtime > 15)
            {
                speedtime = 0;
                moveSpeed = moveSpeed - 2.5f;
                speed--;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Time.timeScale = 0.2f;
            if (slowdown == false && en >= 10)
            {
                en = en - 10;
                Time.timeScale = 0.2f;
                slowdown = true;

            }
            else if (slowdown == true)
            {
                Time.timeScale = 1;
                slowdown = false;
            }
        }



    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "rots(Clone)" || collision.collider.name == "snelrots(Clone)" || collision.collider.name == "schietrots(Clone)" || collision.collider.name == "ink(Clone)" || collision.collider.name == "bossink(Clone)")
        {
            if (!shield)
            {
                gothit = 0;
                _CameraShake.shaketimes = 0;
                audio.PlayOneShot(audio.clip, 1f);
                hp = hp - 1;
            }
            else
            {
                shield = false;
            }
            
        }
        if (collision.collider.name == "speedup(Clone)")
        {
            speedtime = 0;
            if (speed == 0)
            {
                moveSpeed = moveSpeed + 2.5f;
                speed++;
                
            }
            

        }
        if (collision.collider.name == "EnergyBoost(Clone)")
        {
            en = en + 30;
        }
        if (collision.collider.name == "Health(Clone)")
        {
            if (hp !< 7)
            {
                hp = hp + 1;
            }
            
        }
        if (collision.collider.name == "shield(Clone)")
        {
            shield = true;
        }
        if (collision.collider.name == "meteor(Clone)")
        {
            if (!shield)
            {
                gothit = 0;
                audio.PlayOneShot(audio.clip, 1f);
                _CameraShake.shaketimes = 0;
                hp = hp - 2;
            }
            else
            {
                shield = false;
            }
        }
    }
}
