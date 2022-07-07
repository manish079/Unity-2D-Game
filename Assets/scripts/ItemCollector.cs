using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public static int cherries = 0;   //static phale ni tha ab kera

    [SerializeField] public Text CherriesText;

    [SerializeField] private AudioSource CollectSound;

    public void Update()
    {
        CherriesText.text = "Score: " + cherries;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("cherry"))
        {
            CollectSound.Play();    
            Destroy(collision.gameObject);
            cherries++;
            CherriesText.text = "Score : " + cherries;
        }
    }
}