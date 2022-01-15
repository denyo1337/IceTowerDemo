using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float elapsedTime = 0;
    public TextMeshProUGUI timer;
    public Stopwatch sw;

    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0.5f; TO DO
        timer  = GetComponent<TextMeshProUGUI>();
        sw = Stopwatch.StartNew();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        timer.text = string.Format("Time: {0}",elapsedTime.ToString("F2"));
    }
}
