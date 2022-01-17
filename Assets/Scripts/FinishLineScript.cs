using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
{
    public bool isRunning = true;
    public TextMeshProUGUI finishText;
    private void OnCollisionExit2D(Collision2D collision)
    {
        finishText = GetComponent<TextMeshProUGUI>();
        FindObjectOfType<AudioManager>().FinishLine();
        isRunning = false;
        Destroy(FindObjectOfType<PlayerMovement>());
        Destroy(FindObjectOfType<CharacterController2D>());
        collision.gameObject.GetComponent<CircleCollider2D>().sharedMaterial = null; // delete friction
    }
}
