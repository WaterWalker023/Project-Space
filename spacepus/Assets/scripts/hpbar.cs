using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpbar : MonoBehaviour
{
    GameObject Image;
    private walking _walking;

    public Sprite hp1;
    public Sprite hp2;
    public Sprite hp3;
    public Sprite hp4;
    public Sprite hp5;
    public Sprite hp6;
    public Sprite hp7;
    void Start()
    {
        _walking = GameObject.Find("player").GetComponent<walking>();
    }

    void Update()
    {
        if (_walking.hp == 7)
        {
            gameObject.GetComponent<Image>().sprite = hp7;
        }
        if (_walking.hp == 6)
        {
            gameObject.GetComponent<Image>().sprite = hp6;
        }
        if (_walking.hp == 5)
        {
            gameObject.GetComponent<Image>().sprite = hp5;
        }
        if (_walking.hp == 4)
        {
            gameObject.GetComponent<Image>().sprite = hp4;
        }
        if (_walking.hp == 3)
        {
            gameObject.GetComponent<Image>().sprite = hp3;
        }
        if (_walking.hp == 2)
        {
            gameObject.GetComponent<Image>().sprite = hp2;
        }
        if (_walking.hp == 1)
        {
            gameObject.GetComponent<Image>().sprite = hp1;
        }
        
    }
    
}