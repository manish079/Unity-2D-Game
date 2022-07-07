using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Button_Restart_Game : MonoBehaviour
{
   
    public void playAgainFromStarting()
    {
        ItemCollector.cherries = 0;
        life.lifeCounter = 3;

        life.lastCheckPointPos = new Vector2(2.3f, 0);
        SceneManager.LoadScene("start");
    }
}
