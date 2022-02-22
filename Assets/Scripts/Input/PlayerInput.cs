using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
	PlayerInputActions inputActions;
	PlayerMovement playerMovement;
	InputAction movement;

	private void Awake()
	{
		inputActions = new PlayerInputActions();
		playerMovement = GetComponent<PlayerMovement>();
	}

	private void OnEnable()
	{
		movement = inputActions.Gameplay.Movement;
		movement.Enable();
	}

	private void OnDisable()
	{
		movement.Disable();
	}

	private void Update()
	{
		playerMovement.SetMoveDirection(movement.ReadValue<Vector2>());
	}
}
