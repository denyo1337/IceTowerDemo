using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float elapsedTime = 0;
    public TextMeshProUGUI timer;
    public bool isRunning;
    //public Stopwatch sw;

    // Start is called before the first frame update
    void Start()
    {
        isRunning = true;
        //Time.timeScale = 0.5f; TO DO
        timer  = GetComponent<TextMeshProUGUI>();
        //sw = Stopwatch.StartNew();
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<FinishLineScript>().isRunning)
        {
            elapsedTime += Time.deltaTime;
            timer.text = string.Format("Time: {0}", elapsedTime.ToString("F2"));
        }
    }
}
