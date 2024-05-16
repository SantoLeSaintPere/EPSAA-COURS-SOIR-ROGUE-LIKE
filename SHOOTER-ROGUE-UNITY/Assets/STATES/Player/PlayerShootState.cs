using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootState : PlayerBaseState
{
    public PlayerShootState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    float timer;
    public override void InStart()
    {
        stateMachine.shootManager.ShowGun();
        stateMachine.animator.Play("Shoot");
        timer = 0;
    }

    public override void InUpdate(float time)
    {
        timer += time;

        if(timer >= stateMachine.shootManager.fireRate)
            // 60)
        {
            stateMachine.NextState(new PlayerMoveState(stateMachine));
        }

    }

    public override void OnExit()
    {
        stateMachine.shootManager.HideGun();
    }
}