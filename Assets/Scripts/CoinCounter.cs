using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static int coinAmmount;
    public int coinAtFinishedLine = 0 ;
    void Awake()
    {
        score = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        score.text = $"Coins: {coinAmmount}";
        coinAtFinishedLine = coinAmmount;
    }
}
