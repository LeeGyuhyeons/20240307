using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResuit : MonoBehaviour
{
    private int highScore;
    public Text resultTime;
    public Text bestTime;
    public GameObject resultUI;

    private void Start()
    {
        resultUI.SetActive(false);

        //플레이어 프립스 : 유니티에서 데이터를 저장할 때 사용하는 클래스
        if (PlayerPrefs.HasKey("HighScore")) //해당 키가 존재하고 있다면
        {
            highScore = PlayerPrefs.GetInt("HighScore"); // 그 값으로 설정합니다
        }
        else
        {
            highScore = 999; //설정해 놓은 기본 값으로 처리합니다.
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalArea.goal)//목표 지점에 도달했을 때
        {
            resultUI.SetActive(true);//결과 UI창을 활성화합니다
            int result = Mathf.FloorToInt(Timer.time);
            //타이머에서 측정한 시간의 소수점을 버려 정수로 결과를 나타냄
            resultTime.text = "ResultTime : " + result;
            bestTime.text = "BestTime : " + highScore;
            //텍스트에 값을 전달합니다
            if (highScore > result)
            {
                PlayerPrefs.SetInt("HighScor", result);
            }
        }
       
        
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
