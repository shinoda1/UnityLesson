
using System;
using System.Collections.Generic;
//ジェネリック(テンプレート)クラスの部分が使用者の好きな型に変えられる

public class StateMachine<T>
{
    private class State
    {
        //readonry...代入不可
        //関数の呼び出しやメンバー変数への代入は可能￥

        private readonly Action mEnterAction;
        //開始時に呼び出されるデリケート(関数)
        private readonly Action mUpdateAction;
        //開始時に呼び出されるデリケート(関数)
        private readonly Action mExitAction;
        //開始時に呼び出されるデリケート(関数)

        public State(Action updateact = null, Action enteract = null, Action exitact = null)
        {
            mUpdateAction = updateact ?? delegate{ };
            mEnterAction = enteract ?? delegate { };
            mExitAction = exitact ?? delegate { };

        }

        public void Enter()
        {
            mEnterAction();
        }

        public void Update()
        {
            mUpdateAction();
        }

        public void Exit()
        {
            mExitAction();
        }

        private Dictionary<T, State> mStateDictionary = new Dictionary<T, State>();
        private State mCurrentState;


        public void Add(T Key,Action updateAct=null, Action enterAct = null, Action exitAct = null) {
            mStateDictionary.Add(Key, new State(updateAct, enterAct, exitAct));



        }
        public void ChangeState(T key)
        {
            mCurrentState?.Exit();
            mCurrentState = mStateDictionary?[key];
            mCurrentState?.Enter();

        }
        public void CurrentUpdate()
        {
            if (mCurrentState == null)
            {
                return;
            }
            mCurrentState.Update();
            
        }
        public void Clear()
        {
            mStateDictionary.Clear();
            mCurrentState = null;
        }
    }
    
}