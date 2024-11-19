using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerStatus _status;

    Vector3 direction;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _status = GetComponent<PlayerStatus>();
    }

    private void Update()
    {
        MovePosition();
    }

    private void MovePosition()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        if (direction == Vector3.zero) return;
        
        // 1.414 �� �ӵ��� �밢���� �̵��ϴ� ������ ����ȭ�� ���� �ذ� �Ͽ���
        transform.Translate(_status.MoveSpeed * Time.deltaTime * direction.normalized);
    }
}
