using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Game : MonoBehaviour
{
    public void quitTheGame()
    {
        SceneManager.LoadScene("end");
        Debug.Log("Quit game..");
    }
}
