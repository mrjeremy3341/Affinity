using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState
{
	protected Player player;
	protected StateMachine stateMachine;

	public BaseState(Player player, StateMachine stateMachine)
	{
		this.player = player;
		this.stateMachine = stateMachine;
	}

	public virtual void Enter() { }
	public virtual void LogicUpdate() { }
	public virtual void PhsyicsUpdate() { }
	public virtual void Exit() { }
}
