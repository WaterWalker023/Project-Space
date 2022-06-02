using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedbar : MonoBehaviour
{
    private walking _walking;

    public Sprite speed0;
    public Sprite speed1;
    public Sprite speed2;
    public Sprite speed3;
    public Sprite speed4;
    public Sprite speed5;
    public Sprite speed6;
    public Sprite speed7;
    public Sprite speed8;
    public Sprite speed9;
    public Sprite speed10;
    public Sprite speed11;
    public Sprite speed12;
    public Sprite speed13;
    public Sprite speed14;
    public Sprite speed15;
    
    // Start is called before the first frame update
    void Start()
    {
        _walking = GameObject.Find("player").GetComponent<walking>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_walking.speedtime == 0)
        {
            gameObject.GetComponent<Image>().sprite = speed0;
        }
        else if (_walking.speedtime < 1)
        {
            gameObject.GetComponent<Image>().sprite = speed1;
        }
        else if (_walking.speedtime < 2)
        {
            gameObject.GetComponent<Image>().sprite = speed2;
        }
        else if (_walking.speedtime < 3)
        {
            gameObject.GetComponent<Image>().sprite = speed3;
        }
        else if (_walking.speedtime < 4)
        {
            gameObject.GetComponent<Image>().sprite = speed4;
        }
        else if (_walking.speedtime < 5)
        {
            gameObject.GetComponent<Image>().sprite = speed5;
        }
        else if (_walking.speedtime < 6)
        {
            gameObject.GetComponent<Image>().sprite = speed6;
        }
        else if (_walking.speedtime < 7)
        {
            gameObject.GetComponent<Image>().sprite = speed7;
        }
        else if (_walking.speedtime < 8)
        {
            gameObject.GetComponent<Image>().sprite = speed8;
        }
        else if (_walking.speedtime < 9)
        {
            gameObject.GetComponent<Image>().sprite = speed9;
        }
        else if (_walking.speedtime < 10)
        {
            gameObject.GetComponent<Image>().sprite = speed10;
        }
        else if (_walking.speedtime < 11)
        {
            gameObject.GetComponent<Image>().sprite = speed11;
        }
        else if (_walking.speedtime < 12)
        {
            gameObject.GetComponent<Image>().sprite = speed12;
        }
        else if (_walking.speedtime < 13)
        {
            gameObject.GetComponent<Image>().sprite = speed13;
        }
        else if (_walking.speedtime < 14)
        {
            gameObject.GetComponent<Image>().sprite = speed14;
        }
        else if (_walking.speedtime < 15)
        {
            gameObject.GetComponent<Image>().sprite = speed15;
        }


    }
}
