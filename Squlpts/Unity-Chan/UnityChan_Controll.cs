using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AnumatorBehaviour))]


public class UnityChan_Controll : MonoBehaviour
{
    [SerializeField] float rotatespeed = 1.0f;
    [SerializeField] float moovspeed = 1.0f;

    Vector3 trans;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Transform>();
        //   InitializeComponent();
        InitializeState();
    }
    void InitializeState()
    {
    //    StateMachine.Add(AnimationState.Idle, IdleUpdate, IdleInitiaraize);
     //   stateMachine.ChangeState(AnimationState.Idle);
    }
    void INitializeComponent()
{
        
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }
    void IdleUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //         stateMachine.ChangeState(AnimationState);
         
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(trans,1.0f);
        }

    }
    void IdleInitiaraize()
    {
        animator.CrossFadeInFixedTime("Idle", 0.0f);//アニメーションの遷移をさせる　第二引数はどの程度の%速度で実行させるか
    }
    
    void JumpInitiaraize()
    {
        animator.CrossFadeInFixedTime("Jump", 0.0f);
    }
    void JumpUpdate()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
       // stateMachine.Update();    
    }
    enum AnimationState : int
    {
        Idle,

        Run,

        Jump
    }
    StateMachine<AnimationState> stateMachine = new StateMachine<AnimationState>();

    Animator animator;
    Rigidbody rigidbody;
}
