using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_button : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit game..");
    }
}
