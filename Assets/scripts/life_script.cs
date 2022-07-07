using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class life_script : MonoBehaviour
{
    [SerializeField] public static Text life_counter;
    // Start is called before the first frame update
    void Start()
    {
        life_counter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        life_counter.text = "Life: " + life.lifeCounter;
    }
}
