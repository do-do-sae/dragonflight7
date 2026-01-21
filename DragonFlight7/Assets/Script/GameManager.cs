using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //싱글톤
    public static GameManager instance;
    public Text scoreText; //점수를 표시하는 Text객체를 에디터에서 받아오기

    int score = 0; //점수를 관리
    private void Awake()
    {
        if (instance == null) //정적으로 자신을 체크
        {
            instance = this; //자기자신을 인스턴스해서 저장
        }
    }
    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score; //텍스트에 반영
        if (score > 1000)
        {
            SceneManager.LoadScene(1); //두번째 Scene전환 index1일거임
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
