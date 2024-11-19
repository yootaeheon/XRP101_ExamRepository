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
        // 함수의 순서를 조정하여 큐브를 생성하고 큐브의 좌표를 수정하게끔 순서를 조정
        // 이후 위치를 변경해줌 
        CreateCube();
        SetCubePosition(3, 0, 3);
        _cubeController.SetPosition();
    }

    private void SetCubePosition(float x, float y, float z)
    {
        _cubeSetPoint.x = x;
        _cubeSetPoint.y = y;
        _cubeSetPoint.z = z;

        // SetCubePosition() 함수는 _cubeSetPoint의 좌표를 변경해줌
        // 하지만 정작 움직이는 함수인 _cubeController.SetPosition() 함수는 _cubeController.SetPoint 좌표로 설정되어 있음
        // _cubeSetPoint의 좌표를 _cubeController.SetPoint 좌표로 넘겨주어 해결 함
        _cubeController.SetPoint = _cubeSetPoint;
    }

    private void CreateCube()
    {
        GameObject cube = Instantiate(_cubePrefab);
        _cubeController = cube.GetComponent<CubeController>();
        _cubeSetPoint = _cubeController.SetPoint;
    }
}
