using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineTest : MonoBehaviour
{
    enum State : int
    {
        A,
        B,
        C,
    }
    StateMachine<State> stateMachine = new StateMachine<State>();
    [SerializeField] float time;
    // Start is called before the first frame update
    void Start()
    {

//        Debug.LogFormat($ "EnterState =[State.A]");
    }





















    // Update is called once per frame
    void Update()
    {
        
    }
}
