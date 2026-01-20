using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject effect;

    void Start()
    {
        
    }

    void Update()
    {
        //Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    //화면 밖으로 나가면 호출되는 함수
    private void OnBecameInvisible()
    {
        //미사일 지우기
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //trigger 충돌일 경우 한번 실행
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //이펙트 생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            SoundManager.instance.SoundDie();
            //미사일 충돌 / 삭제
            Destroy(collision.gameObject);
            //자기자신 삭제
            Destroy(gameObject);
        }

    }
}
