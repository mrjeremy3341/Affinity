using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody2D body;
	float movementSpeed = 250f;
	public Vector2 movementDirection;
	FacingDirection facingDirection;

	private void Awake()
	{
		body = GetComponent<Rigidbody2D>();
	}

	public void Idle()
	{
		body.velocity = Vector2.zero;
	}

	public void Move()
	{
		body.velocity = movementDirection * movementSpeed * Time.deltaTime;
	}

	public void SetMoveDirection(Vector2 direction)
	{
		movementDirection = direction;
	}

	public void SetFacingDirection(FacingDirection direction)
	{
		facingDirection = direction;
	}

	public FacingDirection GetFacingDirection()
	{
		return facingDirection;
	}
}
