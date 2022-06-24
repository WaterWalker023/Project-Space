using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public Sprite shieldoff;
    public Sprite shieldon;
    public Sprite hit;
    private walking _walking;
    public int framedelay;
    public bool hittoggol;
    // Start is called before the first frame update
    void Start()
    {
        _walking = GameObject.Find("player").GetComponent<walking>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_walking.shield)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = shieldon;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = shieldoff;
        }

        if (_walking.gothit <= 4)
        {
            if (framedelay == 10)
            {
                framedelay = 0;
                if (hittoggol)
                {
                    Debug.Log(framedelay);
                    gameObject.GetComponent<SpriteRenderer>().sprite = shieldoff;
                    hittoggol = true;
                }
                else
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = hit;
                    Debug.Log(framedelay);
                    hittoggol = false;
                    _walking.gothit++;
                }

            }
            else
            {
                framedelay++;
            }
        }


        }
}

