using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    private Vector3 magnitude = new Vector3(0, 0.03f, 0);
    public bool shake;
    public int shaketimes;
    int framedelay;

    void Update()
    {
        if (shaketimes <= 4)
        {
            if (framedelay == 4)
            {
                framedelay = 0;
                if (shake)
                {
                    gameObject.transform.position += magnitude;
                    shake = false;
                }
                else
                {
                    gameObject.transform.position -= magnitude;
                    shake = true;
                    shaketimes++;
                }
                
            }
            else
            {
                framedelay++;
            }
        }


    }
}