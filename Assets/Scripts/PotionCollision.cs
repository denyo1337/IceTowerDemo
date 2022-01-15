using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AudioManager;

public class PotionCollision : MonoBehaviour
{
    public CharacterController2D _playerController;
    public Animator animator;
    private bool isBonusActive = true;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _playerController.m_Rigidbody2D.AddForce(new Vector2(0f, 1500f));
        animator.SetBool("Bonus", isBonusActive);

        //AudioManager finding sound and playing it;
        FindObjectOfType<AudioManager>().Play(SoundNames.Boost);

        Destroy(gameObject);
    }
}
