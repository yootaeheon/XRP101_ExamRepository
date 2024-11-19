using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // ������Ƽ�� ��������� ��� �ڽ��� ȣ���Ͽ� ���� �߻���
    // �̸� �����Ͽ� �ذ�
    public float MoveSpeed { get; set; }

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        MoveSpeed = 5f;
    }
}
