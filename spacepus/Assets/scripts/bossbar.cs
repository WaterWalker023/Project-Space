using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossbar : MonoBehaviour
{
    public Sprite bossbar1;
    public Sprite bossbar2;
    public Sprite bossbar3;
    public Sprite bossbar4;
    public Sprite bossbar5;
    public Sprite bossbar1s;
    public Sprite bossbar2s;
    public Sprite bossbar3s;
    public Sprite bossbar4s;
    public Sprite bossbar5s;
    private bosss _bosss;
    // Start is called before the first frame update
    void Start()
    {
        _bosss = GameObject.Find("boss(Clone)").GetComponent<bosss>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_bosss.hp == 5 && _bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar1;
        }
        if (_bosss.hp == 5 && !_bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar1s;
        }
        if (_bosss.hp == 4 && _bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar2;
        }
        if (_bosss.hp == 4 && !_bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar2s;
        }
        if (_bosss.hp == 3 && _bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar3;
        }
        if (_bosss.hp == 3 && !_bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar3s;
        }
        if (_bosss.hp == 2 && _bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar4;
        }
        if (_bosss.hp == 2 && !_bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar4s;
        }
        if (_bosss.hp == 1 && _bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar5;
        }
        if (_bosss.hp == 1 && !_bosss.hit)
        {
            gameObject.GetComponent<Image>().sprite = bossbar5s;
        }
    }
}
