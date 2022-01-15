using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
	[SerializeField] private float m_JumpForce = 1200f;			
	[Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;								
	[SerializeField] private LayerMask m_WhatIsGround;
	public bool isGrounded = false;
	[SerializeField] float speedFactor = 4f;
	private Rigidbody2D m_Rigidbody2D;
	private bool m_FacingRight = true;  
	private Vector3 m_Velocity = Vector3.zero;
	[Header("Events")]
	[Space]
	public UnityEvent OnLandEvent;
	[System.Serializable]
	public class BoolEvent : UnityEvent<bool> { }

	private void FixedUpdate()
	{
		bool wasGrounded = isGrounded;
		isGrounded = IsGrounded();

		if (!wasGrounded && isGrounded)
			OnLandEvent.Invoke();
	}

	public void Move(float move, bool jump)
	{
		
		Vector3 targetVelocity = new Vector2(move * speedFactor, m_Rigidbody2D.velocity.y);
		m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);

		if (move > 0 && !m_FacingRight)
		{
			Flip();
		}
		else if (move < 0 && m_FacingRight)
		{
			Flip();
		}
		
		if (jump)
		{
			if(isGrounded)
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
		}
	}
    private bool IsGrounded()
    {
		var result = Physics2D.Raycast(transform.position, -transform.up, 1.65f, m_WhatIsGround);
		if (result.transform != null)
        {
			return true;
        }
		return false;
    }
    private void Flip()
	{
		m_FacingRight = !m_FacingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
