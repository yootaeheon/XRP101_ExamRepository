# 4번 문제

주어진 프로젝트는 다음의 기능을 구현하고자 생성한 프로젝트이다.

### 1. Player
- 상태 패턴을 사용해 Idle 상태와 Attack 상태를 관리한다.
- Idle상태에서 Q를 누르면 Attack 상태로 진입한다
  - 진입 시 2초 이후 지정된 구형 범위 내에 있는 데미지를 입을 수 있는 적을 탐색해 데미지를 부여하고 Idle상태로 돌아온다
- 상태 머신 : 각 상태들을 관리하는 객체이며, 가장 첫번째로 입력받은 상태를 기본 상태로 설정한다.

### 2. NormalMonster
- 데미지를 입을 수 있는 몬스터

### 3. ShieldeMonster
- 데미지를 입지 않는 몬스터

위 기능들을 구현하고자 할 때
제시된 프로젝트에서 발생하는 `문제들을 모두 서술`하고 올바르게 동작하도록 `소스코드를 개선`하시오.

## 답안
- 발생 문제
1. 공격을 마치고 다음 코루틴 순서 exit 함수가 호출되지 않음 (범위 내에 있는 모든 몬스터에게 공격을 시도하는 것으로 보임, 그리하여 다음 함수가 호출되지 않음)
   => Tag를 이용하여 NormalMonster만 공격하고 다음 exit 함수가 호출되게 하여 해결

2.  공격 행동을 마치고 Exit 함수가 호출되면서 changeStage 함수가 호출되면 다시 한번 Exit 함수가 호출되면서 이를 계속 반복하게 됨
     => exit 함수가 한번만 호출되게 코드 수정하여 해결
