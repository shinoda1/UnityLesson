using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnumatorBehaviour : StateMachineBehaviour
{
    float enterTime = 0.0f;
    public float normalizetime { get; private set; }
    public bool Istranstion { get; private set; }
    public Action EndCalBack { private get; set; }
    //  = () => { Debug.LogWarning("empty animator callBack"); }




    public override  void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        normalizetime = 0.0f;
        Istranstion = animator.IsInTransition(layerIndex);
        enterTime = Time.time;
       
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Istranstion == false)
        {
            normalizetime=((Time.time-enterTime)*stateInfo.speed)/stateInfo.length);
        }
        Istranstion = animator.IsInTransition(layerIndex);
        
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        
    }

    public void ResetTime()
    {
        enterTime = Time.time;
        normalizetime = 0.0f;
        EndCalBack();
    }
    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMachineEnter is called when entering a state machine via its Entry Node
    //override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}

    // OnStateMachineExit is called when exiting a state machine via its Exit Node
    //override public void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}
}
