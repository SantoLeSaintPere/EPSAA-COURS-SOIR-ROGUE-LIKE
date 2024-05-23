using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootState : PlayerBaseState
{
    public PlayerShootState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void InStart()
    {
        stateMachine.shootManager.ShowGun();
        stateMachine.shootManager.Shoot();
        stateMachine.shootManager.shootTimer = 0;
    }

    public override void InUpdate(float time)
    {
        ShootBehaviour(time);

        MoveShoot();

        CheckForJumpShoot();

        if (!stateMachine.inputReader.isShooting)
        {
                stateMachine.NextState(new PlayerMoveState(stateMachine));
        }

    }

    public override void OnExit()
    {
        stateMachine.shootManager.HideGun();
    }
}
