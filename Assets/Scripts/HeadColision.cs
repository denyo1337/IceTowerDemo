using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadColision : MonoBehaviour
{
    public BoxCollider2D headCollider;
    public CircleCollider2D legsCollider;
    public CharacterController2D controller2D;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
            return;
        if (controller2D.isGrounded)
            return;
        DisableColliders(false);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        DisableColliders(true);
    }
    private void DisableColliders(bool iScollided) 
    {
        headCollider.enabled = iScollided;
        legsCollider.enabled = iScollided;
    }
  
}
