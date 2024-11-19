using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StateAttack : PlayerState
{
    private float _delay = 2;
    private WaitForSeconds _wait;
    
    public StateAttack(PlayerController controller) : base(controller)
    {
        
    }

    public override void Init()
    {
        _wait = new WaitForSeconds(_delay);
        ThisType = StateType.Attack;
    }

    public override void Enter()
    {
        Controller.StartCoroutine(DelayRoutine());
      
       
    }

    public override void OnUpdate()
    {
        Debug.Log("Attack On Update");
    }

    public override void Exit()
    {
        Debug.Log("exit ���� �Ϸ�");
        Machine.ChangeState(StateType.Idle);
    }

    private void Attack()
    {
        Debug.Log("attack ����");
        Collider[] cols = Physics.OverlapSphere(
            Controller.transform.position,
            Controller.AttackRadius
            );

        IDamagable damagable;
        foreach (Collider col in cols)
        {
            if (col.CompareTag("NormalMonster"))
            {
                damagable = col.GetComponent<IDamagable>();
                damagable.TakeHit(Controller.AttackValue);
                Debug.Log("���� ����");
            }
            
        
            // ���ݼ��� �αװ� �߰� ���� �Ʒ��� exit ���� �� �αװ� ���� ���� 
            // ���⼭���� ������ ����
            // ��?
            // col �߿� damable�� �ƴ� ������Ʈ���� ��� ������ �õ��ϴ� ������ �ǽɵ�
        }
    }

    public IEnumerator DelayRoutine()
    {
        yield return _wait;
        Attack();
        Debug.Log("exit ���� ��");
        Exit();
    }

}
