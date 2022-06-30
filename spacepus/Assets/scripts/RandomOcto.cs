using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomOcto : MonoBehaviour
{
    public GameObject rots;
    public GameObject snelrots;
    public GameObject schietrots;
    public GameObject boss;
    private bosss _boss;

    public float gametime;
    int niks = 0;

    float rotstimer;
    float rotsdelay;

    float snelrotstimer;
    float snelrotsdelay;

    float schietrotstimer;
    float schietrotsdelay;

    public float bossdeathtimer;

    public bool noboss = false;
    public bool enemy = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gametime += Time.deltaTime;

        if (gametime > 1 && gametime < 90)
        {
            rotstimer += Time.deltaTime;
            if (rotstimer > rotsdelay)
            {
                Instantiate(rots);
                rotstimer = 0.0f;
                rotsdelay = Random.Range(0.5f, 1.2f);
            }
        }
         

        if (gametime > 20)
        {
            snelrotstimer += Time.deltaTime;
            if (snelrotstimer > snelrotsdelay)
            {
                Instantiate(snelrots);
                snelrotstimer = 0.0f;
                snelrotsdelay = Random.Range(2.0f, 6.0f);
            }
        }

        if (gametime > 50)
        {
            schietrotstimer += Time.deltaTime;
            if (schietrotstimer > schietrotsdelay)
            {
                Instantiate(schietrots);
                schietrotstimer = 0.0f;
                schietrotsdelay = Random.Range(8.0f, 12.0f);
            }
        }

        if (gametime > 90 && !noboss)
        {
            GameObject goBoss = Instantiate(boss);
            _boss = goBoss.GetComponent<bosss>();
            noboss = true;

        }

        if (bossdeathtimer > 1.5f)
        {
            SceneManager.LoadScene("end");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            gametime = 90;
        }
        if (noboss)
        {
            if (_boss.hp == 0)
            {
                bossdeathtimer = bossdeathtimer + Time.deltaTime;
                enemy = false;

            }
        }

    }
}
//bossdeathtimer = bossdeathtimer + Time.deltaTime;
//Debug.Log(bossdeathtimer);
