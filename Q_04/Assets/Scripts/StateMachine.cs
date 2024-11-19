using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    Idle, Attack
}

public class StateMachine
{
    private Dictionary<StateType, PlayerState> _stateContainer;
    public StateType CurrentType { get; private set; }
    private PlayerState CurrentState => _stateContainer[CurrentType];

    public StateMachine(params PlayerState[] states)
    {
        _stateContainer = new Dictionary<StateType, PlayerState>();

        foreach (var s in states)
        {
            if (!_stateContainer.ContainsKey(s.ThisType))
            {
                _stateContainer.Add(s.ThisType, s);    
            }
            s.Machine = this;
        }

        CurrentType = states[0].ThisType;
        CurrentState.Enter();
    }

    public void OnUpdate()
    {
        CurrentState.OnUpdate();
    }

    public void ChangeState(StateType state)
    {
        // Exit �Լ��� ȣ��ǰ� ChangeState �Լ��� ȣ��Ǿ��µ� �ٽ� Exit �Լ��� ȣ�� ���� �ݺ� ��
       // CurrentState.Exit();
        CurrentType = state;
        CurrentState.Enter();
    }
}
