using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total_Score : MonoBehaviour
{
    [SerializeField] private Text tScore;

    void Start()
    {
        tScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tScore.text = "You Score: " + ItemCollector.cherries;

    }
}
