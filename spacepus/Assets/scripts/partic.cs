using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partic : MonoBehaviour
{
    public float death; 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, death);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
