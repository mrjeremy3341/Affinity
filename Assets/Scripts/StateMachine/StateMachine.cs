using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
	BaseState currentState;

	public void Initialize(BaseState startingState)
	{
		currentState = startingState;
		currentState.Enter();
	}

	public BaseState GetState()
	{
		return currentState;
	}

	public void SwitchState(BaseState newState)
	{
		currentState.Exit();
		currentState = newState;
		currentState.Enter();
	}
}
