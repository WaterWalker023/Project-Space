using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOcto : MonoBehaviour
{
    public GameObject rots;
    private float timer;
    public float delay = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            Instantiate(rots);
            //HIER KAN JE zonder caps dingen doen.
            timer = 0.0f;
        }
        
    }
}
