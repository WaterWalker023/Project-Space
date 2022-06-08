using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigatie : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void GoToDeath()
    {
        SceneManager.LoadScene("Death");
    }
    public void GoToStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void GoToEnd()
    {
        SceneManager.LoadScene("End");
    }
    public void Quit()
    {
        Application.Quit(); 
    }
    public void options()
    {
        Debug.Log("press options");
    }
    
}
