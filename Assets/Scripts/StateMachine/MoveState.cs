using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : BaseState
{
	public MoveState(Player player, StateMachine stateMachine) : base(player, stateMachine) { }

	public override void Enter()
	{
		base.Enter();
	}

	public override void Exit()
	{
		base.Exit();
	}

	public override void LogicUpdate()
	{
		base.LogicUpdate();

		if(player.PlayerMovement.movementDirection == Vector2.zero)
		{
			stateMachine.SwitchState(player.IdleState);
		}
	}

	public override void PhsyicsUpdate()
	{
		base.PhsyicsUpdate();

		player.PlayerMovement.Move();
	}
}
