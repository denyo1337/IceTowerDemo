using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinColision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CoinCounter.coinAmmount += 1;
        Destroy(gameObject,0.01f);
        gameObject.SetActive(false);
    }
}
