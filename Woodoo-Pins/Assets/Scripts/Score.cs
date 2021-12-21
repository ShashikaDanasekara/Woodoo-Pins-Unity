using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pinCount = 0;
    Text scoreText;

    void Start()
    {
        pinCount = 0;
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = pinCount.ToString();
    }
}
