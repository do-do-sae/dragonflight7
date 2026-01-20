using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    //디자인패턴 중 하나인데 자주 쓰인다.
    public static SingletonTest instance; //자기자신을 변수로 만들고 어디서든 쓸 수 있다.

    private void Awake()
    {
        if(instance == null)
        {
            instance = this; //자기참조객체
        }
    }
    public void PlayerSound()
    {
        Debug.Log("플레이어 사운드야");
    }
    public void EnemySound()
    {
        Debug.Log("적 사운드야");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
