using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathnoob : MonoBehaviour
{
    private walking _walking;

    public Sprite amdeath;
    public Sprite nodeath;
    // Start is called before the first frame update
    void Start()
    {
        _walking = GameObject.Find("player").GetComponent<walking>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_walking.hp > 2)
        {
            gameObject.GetComponent<Image>().sprite = nodeath;
        }
        else if (_walking.hp <= 2)
        {
            gameObject.GetComponent<Image>().sprite = amdeath;
        }
    }
}
