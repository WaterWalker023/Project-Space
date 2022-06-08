using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enbars : MonoBehaviour
{
    public Slider enbar;
    private int maxen = 100;
    private walking _walking;

    // Start is called before the first frame update
    void Start()
    {
        enbar.maxValue = maxen;
        _walking = GameObject.Find("player").GetComponent<walking>();
    }

    // Update is called once per frame
    void Update()
    {
        enbar.value = _walking.en;
    }

}
