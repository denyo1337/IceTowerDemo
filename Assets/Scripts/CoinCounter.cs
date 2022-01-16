using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static int coinAmmount;
    void Awake()
    {
        score = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        score.text = $"Coins: {coinAmmount}";
    }
}
