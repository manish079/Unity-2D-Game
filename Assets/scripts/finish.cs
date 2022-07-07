using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private AudioSource finishsound;
    private bool leveldone = false;
    public static bool level_done_first = false;  //Used for level 1 has finish and in 2nd level if player died then it again set position on 2nd level(last Checkpoint)
    
    void Start()
    {
        finishsound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player" && !leveldone)
        {
            finishsound.Play();
            leveldone = true;
            level_done_first = true;
            Invoke("CompleteLevel", 2f);
        }


    }
    
    private void CompleteLevel()
    {
        life.lastCheckPointPos = new Vector2(2.3f, 0); //When 1st level complete then second level load and player start from starting position(level-2 player postion of x-axis)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
