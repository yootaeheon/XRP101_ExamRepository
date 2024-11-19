using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // 프로퍼티가 재귀적으로 계속 자신을 호출하여 문제 발생함
    // 이를 수정하여 해결
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
