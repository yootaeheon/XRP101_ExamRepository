using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    private CubeController _cubeController;
    public Vector3 _cubeSetPoint;

  
    private void Start()
    {
        // �Լ��� ������ �����Ͽ� ť�긦 �����ϰ� ť���� ��ǥ�� �����ϰԲ� ������ ����
        // ���� ��ġ�� �������� 
        CreateCube();
        SetCubePosition(3, 0, 3);
        _cubeController.SetPosition();
    }

    private void SetCubePosition(float x, float y, float z)
    {
        _cubeSetPoint.x = x;
        _cubeSetPoint.y = y;
        _cubeSetPoint.z = z;

        // SetCubePosition() �Լ��� _cubeSetPoint�� ��ǥ�� ��������
        // ������ ���� �����̴� �Լ��� _cubeController.SetPosition() �Լ��� _cubeController.SetPoint ��ǥ�� �����Ǿ� ����
        // _cubeSetPoint�� ��ǥ�� _cubeController.SetPoint ��ǥ�� �Ѱ��־� �ذ� ��
        _cubeController.SetPoint = _cubeSetPoint;
    }

    private void CreateCube()
    {
        GameObject cube = Instantiate(_cubePrefab);
        _cubeController = cube.GetComponent<CubeController>();
        _cubeSetPoint = _cubeController.SetPoint;
    }
}
