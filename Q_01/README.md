# 1번 문제

주어진 프로젝트 내에서 CubeManager 객체는 다음의 책임을 가진다
- 해당 객체 생성 시 Cube프리팹의 인스턴스를 생성한다
- Cube 인스턴스의 컨트롤러를 참조해 위치를 변경한다.

제시된 소스코드에서는 큐브 인스턴스 생성 후 아래의 좌표로 이동시키는 것을 목표로 하였다
- x : 3
- y : 0
- z : 3

제시된 소스코드에서 문제가 발생하는 `원인을 모두 서술`하시오.

## 답안

1. 함수의 순서를 조정하여 큐브를 생성하고 큐브의 좌표를 수정하게끔 순서를 조정한 이후 위치를 변경해줌 

2. SetCubePosition() 함수는 _cubeSetPoint의 좌표를 변경해줌
    하지만 정작 움직이는 함수인 _cubeController.SetPosition() 함수는 _cubeController.SetPoint 좌표로 설정되어 있음
    _cubeSetPoint의 좌표를 _cubeController.SetPoint 좌표로 넘겨주어 해결 함

