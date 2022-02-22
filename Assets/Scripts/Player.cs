using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public PlayerInput PlayerInput { get; private set; }
	public PlayerMovement PlayerMovement { get; private set; }

	public StateMachine StateMachine { get; private set; }

	public IdleState IdleState { get; private set; }
	public MoveState MoveState { get; private set; }

	private void Awake()
	{
		StateMachine = new StateMachine();

		IdleState = new IdleState(this, StateMachine);
		MoveState = new MoveState(this, StateMachine);
	}

	private void Start()
	{
		PlayerInput = GetComponent<PlayerInput>();
		PlayerMovement = GetComponent<PlayerMovement>();

		StateMachine.Initialize(IdleState);
	}

	private void Update()
	{
		StateMachine.GetState().LogicUpdate();
	}

	private void FixedUpdate()
	{
		StateMachine.GetState().PhsyicsUpdate();
	}
}
