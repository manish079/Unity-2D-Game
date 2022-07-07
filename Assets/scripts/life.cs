using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    public static int lifeCounter = 3;


    public static Vector2 lastCheckPointPos = new Vector2(2.6f, 0);

    [SerializeField] private AudioSource DeathSound;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }
    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      

        if (collision.gameObject.CompareTag("traps"))
        {
            if(lifeCounter >= 1)
            {
                --lifeCounter;
                loadScene();
            }
            else
            {
                Die();
                SceneManager.LoadScene("LifeOver");
            }
          
        }
    }
    private void loadScene()
    {
        Die();
        SceneManager.LoadScene("LifeLine");
        
    }

    private void Die()
    {
        DeathSound.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");

    }

    public static void RestartLevel()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


