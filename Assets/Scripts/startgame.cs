using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public void loadgame ()
    {
    	SceneManager.LoadScene("SampleScene");
    }

    public void mulaigame ()
    {
    	SceneManager.LoadScene("Mulai Gamenya");
    }


    public void rules ()
    {
    	SceneManager.LoadScene("Rules");
    }

    public void mainmenu ()
    {
    	SceneManager.LoadScene("Main Menu");
    }

    public void howtoplay ()
    {
    	SceneManager.LoadScene("how to play");
    }

    public void quit ()
    {
    	Application.Quit();
    	Debug.Log("Quit!");
    }
}
