using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text Points;
    public int ScoreAmount = 0;

    public TMP_Text Seconds;
    public float InitialSecond = 0f;
    public float SecondSum = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Points.text = "Points: " + (int)ScoreAmount;

        Seconds.text = (int)InitialSecond + "s";
        InitialSecond += Time.unscaledDeltaTime;
    }

    public void AddScore()
    {
        ScoreAmount++;
    }
}
