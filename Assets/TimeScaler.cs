using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    public float TimeNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSeconds());
        PlayerPrefs.SetString("currentScore", "0");
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = TimeNumber;
    }

    private IEnumerator WaitSeconds()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(2);
            TimeNumber += 0.01f;
        }


    }
}
