using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public void RestartTheGame()
    {
        //int x = SceneManager.GetActiveScene().buildIndex;
        if(finish.level_done_first == false)
        {
            SceneManager.LoadScene("level 1");
        }
        else
        {
            SceneManager.LoadScene("level 2");
        }
    }
}
