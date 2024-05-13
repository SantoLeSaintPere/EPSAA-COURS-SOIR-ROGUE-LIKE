using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [HideInInspector]
    public CharacterController characterController;
    [HideInInspector]
    public PlayerInputReader inputReader;
    [HideInInspector]
    public PlayerForceReceiver forceReceiver;
    [HideInInspector]
    public PlayerGroundDetector groundDetector;
    [HideInInspector]
    public PlayerAttackManager attackManager;
    [HideInInspector]
    public PlayerShootManager shootManager;
    [HideInInspector]
    public PlayerDirectionManager directionManager;


    [HideInInspector]
    public SpriteRenderer spriteRenderer;
    [HideInInspector]
    public Animator animator;

    public Transform holder;

    [Header("MOTION")]
    public bool autoRun;
    public float speed = 5f;



    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

        inputReader = GetComponent<PlayerInputReader>();
        forceReceiver = GetComponent<PlayerForceReceiver>();
        groundDetector = GetComponent<PlayerGroundDetector>();
        attackManager = GetComponent<PlayerAttackManager>();
        shootManager = GetComponent<PlayerShootManager>();
        directionManager = GetComponent<PlayerDirectionManager>();

        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponentInChildren<Animator>();



        NextState(new PlayerMoveState(this));
    }
}