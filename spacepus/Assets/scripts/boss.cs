using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss : MonoBehaviour
{
    int attacktype;
    public int hp;
    bool inattack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0)
        {
            SceneManager.LoadScene("end");
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "SAnicBoom(Clone)")
        {
            if (!inattack)
            {
                hp = hp - 1;
            }
            
        }
    }
}
