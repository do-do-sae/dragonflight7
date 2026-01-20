using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = true;
    public GameObject enemy;
    void Start()
    {
        //InvokeRepeating("함수이름", 초기지연시간, 지연할 시간);
        InvokeRepeating("Spawn", 1f, 0.5f);
    }
    void Spawn()
    {
        // 1. 랜덤한 X축 위치 계산 (예: -2.5f ~ 2.5f)
        // 화면 크기에 맞게 숫자를 조절해 주세요.
        float randomX = Random.Range(-2.3f, 2.3f);
        // 2. 새로운 생성 위치 설정 (Y와 Z는 스폰 매니저의 위치를 그대로 사용)
        Vector3 spawnPos = new Vector3(randomX, transform.position.y, transform.position.z);
        if(enableSpawn)
        {
            //미사일 프리팹, 런쳐포지션, 방향값 없음
            Instantiate(enemy, spawnPos, Quaternion.identity);
        }
        
    }
    void Update()
    {
        
    }
}
