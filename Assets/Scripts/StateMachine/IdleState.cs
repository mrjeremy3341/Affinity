using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
	public IdleState(Player player, StateMachine stateMachine) : base(player, stateMachine) { }

	public override void Enter()
	{
		base.Enter();

		player.PlayerMovement.Idle();
	}

	public override void Exit()
	{
		base.Exit();
	}

	public override void LogicUpdate()
	{
		base.LogicUpdate();

		if (player.PlayerMovement.movementDirection != Vector2.zero)
		{
			stateMachine.SwitchState(player.MoveState);
		}
	}

	public override void PhsyicsUpdate()
	{
		base.PhsyicsUpdate();
	}
}
